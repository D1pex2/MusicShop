//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicShop.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int IdProduct { get; set; }
        public int IdUser { get; set; }
        public decimal Rating { get; set; }
    
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}