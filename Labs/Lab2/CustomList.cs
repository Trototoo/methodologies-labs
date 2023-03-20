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

    public void Append(T value)
    {
        elements.Add(value);
    }

    public void Insert(T value, int index)
    {
        elements.Insert(index, value);
    }

    public void Delete(int index)
    {
        elements.RemoveAt(index);
    }

    public void DeleteAll(T seekedElement)
    {
        elements.RemoveAll(element => element.Equals(seekedElement));
    }

    public T Get(int index)
    {
        return elements[index];
    }

    public CustomList<T> Clone()
    {
        var newList = new CustomList<T>();
        foreach (T item in elements)
        {
            newList.Append(item);
        }

        return newList;
    }
}