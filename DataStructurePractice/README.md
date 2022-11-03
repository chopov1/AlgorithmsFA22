### Stack
I am pushing the items to the stack backwords, so when I pop the items it will read
in the correct order

```c#
public Stack<string> stringsToStack(List<string> lines)
        {
            Stack<string> stack = new Stack<string>();
            for(int i = lines.Count-1; i > 0; i--)
            {
                stack.Push(lines[i]);
            }
            return stack;
        }
```
### Queue
I enqueue the items from top to bottom in terms of the line order of the data file,
so when dequeueing it reads in the correct order.

```c#
 public Queue<string> stringsToQueue(List<string> lines)
        {
            Queue<string> queue = new Queue<string>();
            foreach(string line in lines)
            {
                queue.Enqueue(line);
            }
            return queue;
        }
```
### Array
If I want to read out the data in order I can just linearly search through and read each value. However if I want to know a specific word used in the data I will again need to linearly search, vs the map, which I can simply use the first letter of the word I am looking for and get a result much quicker.

```c#
public string[] stringsToArray(List<string> lines)
        {
            string[] arry = new string[lines.Count];
            for(int i =0; i < arry.Length; i++)
            {
                arry[i] = lines[i];
            }
            return arry;
        }
```
### Map
I am in a way creeating my own hash function. It is simply assigning values
to be at the key associated with the first letter of the value. My buckets
in this case are the arrays I create to contain multiple values if there are collisions.

```c#
public Dictionary<char, List<string>> stringsToMap(List<string> lines)
        {
            Dictionary<char, List<string>> result = new Dictionary<char, List<string>>();
            foreach(var line in lines)
            {
                if (!result.ContainsKey(line[0]))
                {
                    List<string> list = new List<string>();
                    list.Add(line);
                    result.Add(line[0], list);
                }
                else
                {
                    result[line[0]].Add(line);
                }
            }
            return result;
        }
```