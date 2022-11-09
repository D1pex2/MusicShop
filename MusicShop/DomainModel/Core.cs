namespace MusicShop.DomainModel
{
    /// <summary>
    /// Класс контекста данных
    /// </summary>
    sealed class Core
    {
        /// <summary>
        /// Поле контекста данных
        /// </summary>
        private static MusicShopEntities context;

        /// <summary>
        /// Свойство контекста данных
        /// </summary>
        public static MusicShopEntities Context
        {
            get
            {
                if (context == null)
                {
                    context = new MusicShopEntities();
                }
                return context;
            }
        }

        private Core() { }
    }
}