Just a tree. Simple tree.

Imagine you have a file-tree structure. You want to store it in some way. If you haven't worked with tree before, perhaps it will be for you a non-trivial idea.

You just need to use a tree (in design patterns it's callign `composite`)!

Let's build a common interface for a node(and it's calling ofTen 'compound'):

```
public interface ICompound
{
    public void rename(string name);
    public void delete();
}
```

And then create a `Folder` and a `File` nodes, where a `Folder` will hold multiples of `Folder`s or `File` types (here is the main idea of this pattern! look again!) and the `File`, which will realize the common `File` object requirements (e.g. read and write).
