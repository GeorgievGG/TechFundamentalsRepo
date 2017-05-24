using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SocialMediaPosts
{
    public class SocialMediaPosts
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var likes = new Dictionary<string, int>();
            var dislikes = new Dictionary<string, int>();
            var comments = new Dictionary<string, Dictionary<string, string>>();
            var commentString = string.Empty;
            while (input != "drop the media")
            {
                var inputList = input.Split(' ');
                switch (inputList[0])
                {
                    case "post":
                        Post(inputList[1], likes, dislikes, comments);
                        break;
                    case "like":
                        Like(inputList[1], likes);
                        break;
                    case "dislike":
                        Dislike(inputList[1], dislikes);
                        break;
                    case "comment":
                        for (int i = 3; i < inputList.Length; i++)
                        {
                            if (i != inputList.Length - 1)
                            {
                                commentString += inputList[i] + " ";
                                continue;
                            }
                            commentString += inputList[i];
                        }
                        Comment(inputList[1], inputList[2], commentString, comments);
                        commentString = string.Empty;
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var post in likes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Post: {post.Key} | Likes: {likes[post.Key]} | Dislikes: {dislikes[post.Key]}");
                Console.WriteLine("Comments:");

                if (comments[post.Key].Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comment in comments[post.Key])
                    {
                        Console.WriteLine($"*  {comment.Key}: {comment.Value}");
                    }
                }
            }
        }

        private static void Post(string postName, Dictionary<string, int> likes, Dictionary<string, int> dislikes, Dictionary<string, Dictionary<string, string>> comments)
        {
            likes.Add(postName, 0);
            dislikes.Add(postName, 0);
            comments.Add(postName, new Dictionary<string, string>());
        }

        private static void Like(string postName, Dictionary<string, int> likes)
        {
            likes[postName]++;
        }

        private static void Dislike(string postName, Dictionary<string, int> dislikes)
        {
            dislikes[postName]++;
        }

        private static void Comment(string postName, string commentator, string content, Dictionary<string, Dictionary<string, string>> comments)
        {
            if (!comments.ContainsKey(postName))
            {
                comments.Add(postName, new Dictionary<string, string>());
            }
            comments[postName].Add(commentator, content);
        }
    }
}
