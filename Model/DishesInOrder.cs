//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeDemoLeontevaPetrova.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DishesInOrder
    {
        public int Id { get; set; }
        public int DishId { get; set; }
        public int OrderId { get; set; }
        public int StatusId { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual Order Order { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
    }
}
