﻿namespace DemoCRM.Data
{
    public class DataTableRespnse<T>
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public T data { get; set; }
    }
}