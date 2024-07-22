using Game.Character;
using Microsoft.Data.SqlClient;

namespace Game.Database
{
    internal class Connection
    {
        private static readonly string Server = "";
        private static readonly string User = "";
        private static readonly string DBname = "";
        private static readonly string Password = "";
        private SqlConnection? Cnn { get; set; }

        public void Open()
        {
            Cnn = new SqlConnection(string.Format(
                    "Server={0};User Id={1};Database={2};Password={3};TrustServerCertificate=True",
                    Server,
                    User,
                    DBname,
                    Password));
        }

        public void Query()
        {
            Open();

            string sql = "SELECT name, collation_name FROM sys.databases";

            using SqlCommand command = new(sql, Cnn);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            }

            Close();
        }

        public void SavePoint()
        {
            Open();

            string sql = @"
                INSERT INTO Ricardo_Player (Name, HP, Gold)
                VALUES (@Name, @HP, @Gold)
            ";

            using SqlCommand command = new(sql, Cnn);
            command.Parameters.AddWithValue("@Name", Player.Instance.Name);
            command.Parameters.AddWithValue("@HP", Player.Instance.HP);
            command.Parameters.AddWithValue("@Gold", Player.Instance.Gold);

            int affectedRows = command.ExecuteNonQuery();

            Close();
        }

        public void LoadCharacter(int _id)
        {
            Open();

            string sql = $"SELECT * FROM Ricardo_Player where ID = @Id";

            using SqlCommand command = new(sql, Cnn);
            command.Parameters.AddWithValue("@Id", _id);

            using SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Player player = Player.Instance;

            int id = reader.GetInt32(0);
            string name = reader.GetString(1);
            int hp = reader.GetInt32(2);
            int gold = reader.GetInt32(3);

            player.Id = id;
            player.Name = name;
            player.Gold = gold;
            player.UpdateHP(hp);

            Close();
        }

        public List<string> PlayerList()
        {
            Open();

            string sql = "SELECT TOP 10 * FROM Ricardo_Player";
            List<string> rows = new List<string>();
            string row = "";

            using SqlCommand command = new(sql, Cnn);
            using SqlDataReader reader = command.ExecuteReader();

            row = "Id Name Hp Gold";
            rows.Add(row);
            while (reader.Read())
            {
                row = $"{reader.GetInt32(0)}){reader.GetString(1)}|{reader.GetInt32(2)}";
                rows.Add(row);
            }

            Close();

            return rows;
        }

        public void CreateTable()
        {
            Open();

            string sql = @"
                CREATE TABLE Player (
                    ID INT NOT NULL IDENTITY(1, 1),
                    Name NVARCHAR(64),
                    HP INT NOT NULL,
                    Gold INT NOT NULL,
                    CONSTRAINT ricardo_player_pk PRIMARY KEY(Id)
            )";

            using SqlCommand command = new(sql, Cnn);
            int affectedRows = command.ExecuteNonQuery();

            Close();
        }

        public void DropTable()
        {
            Open();

            string sql = "DROP TABLE Player";

            using SqlCommand command = new(sql, Cnn);
            int affectedRows = command.ExecuteNonQuery();

            Close();
        }

        public void Close()
        {
            Cnn?.Close();
        }
    }
}
