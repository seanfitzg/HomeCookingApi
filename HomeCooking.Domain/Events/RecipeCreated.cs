﻿namespace HomeCooking.Domain.Events
{
    public class RecipeCreated : IEvent
    {
        public RecipeCreated(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get;  }
        public string Name { get; }
    }
}