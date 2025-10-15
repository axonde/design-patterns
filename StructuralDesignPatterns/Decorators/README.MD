We create a simple CI system. The user can manually configure those tests for our submitted code:

- `Test()`  // base tests
- `CodeStyleTest()`
- `A11yTest()`  (`A11y` is an abbrevation for accessibility in web domen)
- `StressTest()`

But, the user for any project can configure any test sequences.

Here the `decorator` pattern shines!

We will decorate the base `Test()` methods, which will be launched every time, and additionally add some tests on top)

Look first off all at `Client.cs` - this offer a direct view of the pattern's utility.
