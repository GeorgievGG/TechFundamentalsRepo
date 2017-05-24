using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.RoliTheCoder
{
    public class RoliTheCoder
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var validateRegex = new Regex(@"^([0-9]+) (#\w+)(( @\w+)*)$");
            //var idRegex = new Regex(@"^[0-9]+");
            //var eventRegex = new Regex(@"#\w+");
            //var participantsRegex = new Regex(@"@\w+");
            var eventsList = new Dictionary<int, Event>();
            while (input != "Time for Code")
            {
                if (validateRegex.IsMatch(input))
                {
                    var id = int.Parse(validateRegex.Match(input).Groups[1].Value);
                    var evnt = validateRegex.Match(input).Groups[2].Value;
                    var participantsElement = validateRegex.Match(input).Groups[3].Value;
                    var participants = participantsElement.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (!eventsList.ContainsKey(id))
                    {
                        eventsList.Add(id, new Event(id, evnt, new HashSet<string>()));
                        foreach (var participant in participants)
                        {
                            eventsList[id].Participants.Add(participant);
                        }
                    }
                    else
                    {
                        if (eventsList[id].EventName == evnt)
                        {
                            foreach (var participant in participants)
                            {
                                eventsList[id].Participants.Add(participant);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            eventsList = eventsList.OrderByDescending(x => x.Value.Participants.Distinct().Count()).ThenBy(x => x.Value.EventName).ToDictionary(x => x.Key, y => y.Value);
            foreach (var evt in eventsList)
            {
                Console.WriteLine($"{evt.Value.EventName.Replace("#", "")} - {evt.Value.Participants.Distinct().Count()}");
                evt.Value.Participants.OrderBy(x => x).ToList().ForEach(y => Console.WriteLine(y));
            }
        }
    }
    public class Event
    {
        public Event (int ID, string eventName, HashSet<string> participants)
        {
            this.ID = ID;
            this.EventName = eventName;
            this.Participants = participants;
        }
        public int ID { get; set; }
        public string EventName { get; set; }
        public HashSet<string> Participants { get; set; }
    }
}
