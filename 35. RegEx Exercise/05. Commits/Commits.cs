using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.Commits
{
    public class Commits
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var urlRegex = new Regex(@"^https:\/\/github.com\/([a-zA-Z0-9-]+)\/([a-zA-Z\-_]+)\/commit\/([0-9a-f]{40}),(.+?),(\d+?),(\d+?)$");
            var commits = new Dictionary<string, Dictionary<string, List<Commit>>>();
            while (input != "git push")
            {
                var commit = urlRegex.Match(input);
                if (commit.Success)
                {
                    var user = commit.Groups[1].ToString();
                    var repo = commit.Groups[2].ToString();
                    var hash = commit.Groups[3].ToString();
                    var message = commit.Groups[4].ToString();
                    var additions = int.Parse(commit.Groups[5].ToString());
                    var deletions = int.Parse(commit.Groups[6].ToString());
                    var newCommit = new Commit(hash, message, additions, deletions);
                    if (!commits.ContainsKey(user))
                    {
                        commits.Add(user, new Dictionary<string, List<Commit>>());
                    }
                    if (!commits[user].ContainsKey(repo))
                    {
                        commits[user].Add(repo, new List<Commit>());
                    }
                    commits[user][repo].Add(newCommit);
                }
                input = Console.ReadLine();
            }
            foreach (var user in commits.Keys.OrderBy(x => x))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{user}:");
                foreach (var repo in commits[user].Keys.OrderBy(x => x))
                {
                    Console.WriteLine($"  {repo}:");
                    commits[user][repo].ForEach(x => Console.WriteLine($"    commit {x.hash}: {x.message} ({x.insertions} additions, {x.deletions} deletions)"));
                    Console.WriteLine($"    Total: {commits[user][repo].Select(x => x.insertions).Sum()} additions, {commits[user][repo].Select(x => x.deletions).Sum()} deletions");
                }
            }
        }
    }
    public class Commit
    {
        public Commit(string hash, string message, int insertions, int deletions)
        {
            this.hash = hash;
            this.message = message;
            this.insertions = insertions;
            this.deletions = deletions;
        }
        public string hash { get; set; }
        public string message { get; set; }
        public int insertions { get; set; }
        public int deletions { get; set; }
    }
}