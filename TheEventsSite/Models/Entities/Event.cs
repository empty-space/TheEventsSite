using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheEventsSite.Models.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }

        public Guid Author { get; set; }

        public DateTime PublicDate{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public int TicketsMaxCount { get; set; }
        public int TicketsSold { get; set; }
        public string ManagerName{ get; set; }
        public string ManagerPhone { get; set; }
        /// <summary>
        /// Lecture, webinar, service..
        /// </summary>
        public EventFormat EventType{ get; set; }
    }
    public enum
}