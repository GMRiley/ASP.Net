//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeekNine.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    using System.ComponentModel;

    public partial class Item
    {
        public int Id { get; set; }

        [DisplayName("Item Name")]
        public string itemName { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

        [DisplayName("Upload Image")]
        public string imagePath { get; set; }

        public HttpPostedFileBase imageFile { get; set; }

    }
}