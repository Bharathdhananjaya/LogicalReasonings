using System;
using Elasticsearch.Net;
using ElasticSearchClient;
using Nest;
 

namespace ElasticSearchClient
{
    class Program
    {

        static Uri node = new Uri("http://localhost:9200/");

        static ConnectionConfiguration config = new ConnectionConfiguration(node);

        static ElasticLowLevelClient client = new ElasticLowLevelClient(config);

        static void Main(string[] args)
        {
            new Program().ArrayIssues();
        //    var myJson = new { hello = "world" };
        //    var result = client.Index<object>("bharath", "string", "1", myJson);
        //    new Program().ReadDataFromElasticSearch("1");
            Console.Read();
        }


        private void ReadDataFromElasticSearch(string id)
        {
            var data = client.Get<object>("bharath", "string", id);
            Console.WriteLine("Elastic search response"  + data.Body);

        }



        private void ConnectToElasticSearch()
        {


        }


        public void WriteToElasticSearch()
        {

        }


        public void ArrayIssues()
        {
            int sumToCheck = 5;
            int[] s = { 1, 2, 3, 4, 5 };


            for(int i=0; i< s.Length;i++)
            {
                for(int j=1;j<s.Length;j++)
                {
                    if(s[i] +s[j] == sumToCheck)
                    {
                        Console.WriteLine(" Numbers " + s[i] +"," + s[j]);
                    }
                }
            }


        }



    }

    

    


   
}
