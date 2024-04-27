using HWHDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;


/*


SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

stringBuilder.DataSource = "DESKTOP-87SLOG3";

stringBuilder.InitialCatalog = "DotNetTrainingBatch4";
stringBuilder.UserID = "sa";
stringBuilder.Password = "sa@123";


SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

connection.Open();
Console.WriteLine("Connection Open");

String sql = "select * from Tbl_Blog";

SqlCommand cmd = new SqlCommand(sql, connection);

SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

DataTable dt = new DataTable();

sqlDataAdapter.Fill(dt);









connection.Close();


foreach(DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id =>"+dr["BlogId"]);
    Console.WriteLine("Blog Title =>" + dr["BlogTitle"]);
    Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
    Console.WriteLine("-----------------------------");


}

*/


//AdoDotNetExamples adoDotNetExamples = new AdoDotNetExamples();

//adoDotNetExamples.Read();  // F11
//adoDotNetExamples.Create("title","autho","content");
//adoDotNetExamples.Update(10, "test title", "test author", "test content");

//adoDotNetExamples.Delete(10);
//
//adoDotNetExamples.Edit(10);
//adoDotNetExamples.Edit(2);

//DapperExample dapperExample = new DapperExample();

//dapperExample.Run();


EFCoreExample eFCoreExample = new EFCoreExample();  
eFCoreExample.Run();
Console.ReadLine();








