//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitterBuisness.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tweet
    {
        public int TweetId { get; set; }
        public string TweetUser { get; set; }
        public string TweetMessage { get; set; }
        public System.DateTime TweetTime { get; set; }
    }
}