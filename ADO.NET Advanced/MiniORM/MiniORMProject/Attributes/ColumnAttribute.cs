﻿namespace MiniORMProject.Attributes
{
    using System;

    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; set; }
    }
}
