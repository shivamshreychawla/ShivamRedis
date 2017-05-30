using ServiceStack.Redis;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace shreoyedis
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    using (var redis = new RedisClient())
        //    {
        //        var redisUsers = redis.As<Person>();
        //        var rick = new Person { Id = redisUsers.GetNextSequence(), Name = "Rick" };
        //        var becky = new Person { Id = redisUsers.GetNextSequence(), Name = "Becky" };

        //        redisUsers.Store(rick);
        //        redisUsers.Store(becky);
        //        var allthePeople = redisUsers.GetAll();
        //        Console.WriteLine(allthePeople.Dump());
        //        Console.ReadLine();


        //    }
        //}

        static void Main(string[] args)
        {
            ConnectionMultiplexer redisConn = ConnectionMultiplexer.Connect("localhost");
            IDatabase redDb = redisConn.GetDatabase();
            //redDb.KeyDelete("Key1");
            if (string.IsNullOrWhiteSpace(redDb.StringGet("Key1")))
                redDb.StringSet("Key1", "value1");
            Console.WriteLine(redDb.StringGet("Key1"));
            Console.Read();
        }
    }
}
