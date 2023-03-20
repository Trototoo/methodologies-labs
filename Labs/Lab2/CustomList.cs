﻿namespace Lab2;

public class CustomList<T>
{
    public List<T> elements;
    public int Length
    { get => elements.Count; }

    public CustomList()
    {
        elements = new List<T>();
    }
}