using System.Text;

namespace Lab2;

public class CustomList<T>
{
    public Node<T>? Head 
    { get; private set; }
    public Node<T>? Tail 
    { get; private set; }
    public int Length 
    { get; set; }

    public CustomList()
    {
        Length = 0;
        Head = null;
        Tail = null;
    }
    
    private void AddHead(T data)
    {
        Node<T> newNode = new Node<T>(data);
        
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.NextNode = Head;
            Head = newNode;
        }
        
        Length++;
    }
    public void Append(T value)
    {
        Node<T> newNode = new Node<T>(value);
        
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.NextNode = newNode;
            Tail = newNode;
            Tail.NextNode = Head;
        }
        
        Length++;
    }

    public void Insert(T data, int index)
    {
        if (index < 0 || index > Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Node<T> newNode = new Node<T>(data);
        if (index == 0)
        {
            AddHead(data);
        }
        else if (index == Length)
        {
            Append(data);
        }
        else
        {
            Node<T> current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.NextNode;
            }

            newNode.NextNode = current.NextNode;
            current.NextNode = newNode;
            Length++;
        }
    }


    public T Delete(int index)
    {
        if (index < 0 || index >= Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        Node<T>? current = Head;
        Node<T>? previous = null;

        for (int i = 0; i < index; i++)
        {
            previous = current;
            current = current.NextNode;
        }

        T value = current.Data;

        if (previous == null)
        {
            Head = current.NextNode;
        }
        else
        {
            previous.NextNode = current.NextNode;
        }

        if (current == Tail)
        {
            Tail = previous;
        }

        current.NextNode = null;
        Length--;

        return value;
    }
    
    public void DeleteAll(T value)
    {
        int index = 0;
        Node<T>? current = Head;
        while (index < Length)
        {
            if (current!.Data.Equals(value))
            {
                current = current.NextNode;
                Delete(index);
            }
            else
            {
                index++;
                current = current.NextNode;
            }
        }
    }

    public T Get(int index)
    {
        if (index < 0 || index >= Length)
        {
            throw new ArgumentOutOfRangeException();
        }

        Node<T> current = Head;
        int currentIndex = 0;

        while (current != null && currentIndex != index)
        {
            current = current.NextNode;
            currentIndex++;
        }

        return current.Data;
    }

    public CustomList<T> Clone()
    {
        CustomList<T> newList = new CustomList<T>();
        Node<T> current = Head;
        int index = 0;

        while (index != Length)
        {
            newList.Append(current.Data);
            current = current.NextNode;
            index++;
        }

        return newList;
    }

    public void Reverse()
    {
        if (Head == null || Head.NextNode == null) return;

        Node<T> current = Head;
        Node<T> previous = null;
        Node<T> next;

        do
        {
            next = current.NextNode;
            current.NextNode = previous;
            previous = current;
            current = next;
        } while (current != Head);

        Head = previous;
    }
    
    public int FindFirst(T value)
    {
        Node<T> current = Head;
        int index = 0;

        while (index != Length)
        {
            if (current.Data.Equals(value))
            {
                return index;
            }

            current = current.NextNode;
            index++;
        }

        return -1;
    }
    
    public int FindLast(T value)
    {
        int index = -1;
        int currIndex = 0;
        Node<T> currNode = Head;

        while (currIndex != Length)
        {
            if (currNode.Data.Equals(value))
            {
                index = currIndex;
            }

            currNode = currNode.NextNode;
            currIndex++;
        }

        return index;
    }
    
    public void Clear()
    {
        Head = null;
        Length = 0;
    }
    
    public void Extend(CustomList<T> listToExtend)
    {
        Node<T> current = listToExtend.Head;
        int index = 0;
        while (index < listToExtend.Length)
        {
            Append(current.Data);
            current = current.NextNode;
            index++;
        }
    }



    public override string ToString()
    {
        var index = 0;
        Node<T> tempNode = Head!;
        var stringBuilder = new StringBuilder();
        while (index != Length)
        {
            stringBuilder.Append($"{tempNode.Data} ");
            tempNode = tempNode.NextNode!;
            ++index;
        }

        string outputString = stringBuilder.ToString();
        if (outputString != "")
        {
            outputString = outputString.Remove(outputString.Length - 1);
        }

        return outputString;
    }
}