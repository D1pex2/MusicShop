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
    
    public partial class Cart
    {
        public int IdProduct { get; set; }
        public int IdUser { get; set; }
        public short Quantity { get; set; }
    
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}