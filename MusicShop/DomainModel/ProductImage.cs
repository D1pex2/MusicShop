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
    
    public partial class ProductImage
    {
        public int IdImage { get; set; }
        public int IdProduct { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
