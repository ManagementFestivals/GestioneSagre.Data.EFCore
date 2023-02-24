﻿namespace GestioneSagre.Data.EFCore.Core.Interfaces;

public interface IEntity<TKey>
{
    /// <summary>
    /// Defines the type of the ID field
    /// </summary>
    TKey Id { get; set; }
}