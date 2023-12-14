using System.Data;
using System.Data.SqlClient;

namespace DBProgAct {
    public class ClubRegistrationQuery {

        private readonly SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSauce;

        private string connString;

        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;
        public ClubRegistrationQuery() {
            string server = "(your server here)";
            connString = $"Data Source={server};Initial Catalog=ClubDB;Integrated Security=True;TrustServerCertificate=True";
            sqlConnect = new SqlConnection(connString);
            dataTable = new DataTable();
            bindingSauce = new BindingSource();
        }

        public bool DisplayList() {
            try {
                sqlConnect.Open();
                string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
                sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
                dataTable.Clear();
                sqlAdapter.Fill(dataTable);
                bindingSauce.DataSource = dataTable;
                return true;
            } catch {
                return false;
            } finally {
                sqlConnect.Close();
            }
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string
MiddleName, string LastName, int Age, string Gender, string Program) {
            try {
                sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, " +
            "@FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
                sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                return true;
            } catch {
                return false;
            }
        }

        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, 
            string LastName, int Age, string Gender, string Program) {
            try {
                sqlCommand = new SqlCommand("UPDATE ClubMembers SET " +
                                            "FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program " +
                                            "WHERE StudentID = @StudentID", sqlConnect);
                sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
                sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                return true;
            } catch {
                return false;
            }
        }
    }
}
