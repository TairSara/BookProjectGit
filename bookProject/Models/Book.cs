//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bookProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Purchases = new HashSet<Purchase>();
            this.Rentals = new HashSet<Rental>();
            this.Reviews = new HashSet<Review>();
            this.ShoppingCarts = new HashSet<ShoppingCart>();
            this.WaitLists = new HashSet<WaitList>();
        }
    
        public int BookID { get; set; }
        public string Title { get; set; }
        public string MainAuthor { get; set; }
        public string Publisher { get; set; }
        public int PublishYear { get; set; }
        public Nullable<decimal> RentalPrice { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<int> AgeRestriction { get; set; }
        public string Genre { get; set; }
        public Nullable<bool> IsAvailable { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> IsForRent { get; set; }
        public Nullable<decimal> OriginalPrice { get; set; }
        public Nullable<System.DateTime> DiscountEndDate { get; set; }
        public Nullable<bool> IsRented { get; set; }
        public Nullable<bool> IsEPUBAvailable { get; set; }
        public Nullable<bool> IsF2BAvailable { get; set; }
        public Nullable<bool> IsMobiAvailable { get; set; }
        public Nullable<bool> IsPDFAvailable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaitList> WaitLists { get; set; }
    }
}