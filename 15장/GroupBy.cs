using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15장
{
    internal class GroupBy
    {
        static void MainGroupBy()
        {
            Profile[] arr =
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 },
            };

            var list = from profile in arr
                       orderby profile.Height
                       group profile by profile.Height < 175 into g
                       select new { GroupKey = g.Key, Profiles = g };
            foreach (var Group in list)
            {
                Console.WriteLine(Group.GroupKey);
                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($"{profile.Name} : {profile.Height}");
                }
            }
        }
    }
}
