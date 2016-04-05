using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RemotableObject
{
    public class RemoteClass : MarshalByRefObject
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ILJDUI5;Initial Catalog=DSProject;Integrated Security=True");
        int[] qs = new int[10];
        public int[] createQs()
        {
            int i = 1;
            IEnumerable<int> questions = Enumerable.Range(1, 4).OrderBy(x => Guid.NewGuid()).Take(3);
            foreach (int num in questions)
            {
                qs[i] = num;
                i++;
            }
            //if (!(String.IsNullOrEmpty(qs)))
            //   qs=qs.Substring(0, qs.Length - 1);
            return qs;
        }
        public SqlDataReader generateQsAns(int[] qs, int qs_no)
        {
            int question = qs[qs_no];
            conn.Open();
            SqlCommand cmd = new SqlCommand("select question_name,correct_ans from Question_Answer_tbl where question_id= " + question + ";", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
