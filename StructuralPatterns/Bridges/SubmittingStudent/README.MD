We have a huge group of `Student`s. Everyone want to turn in the lab! Everyone! So we need to engage all avaible `Mentor`s for checking. However, there is a problem... Not every `Mentor` is so kind that we waiting from him (personally i have so lot situations where there it was true, unfortunately).

This is a PERFECT case for `Bridge` pattern. We have a complicated implementation for every `Mentor`s `CheckLab` different methods, and don't want (very!) to use some constructions like `Student : StudentWithABadMentor`, `StudentWithASoSoMentor` and bla bla bla.

Perfect way - association. Just let's use aggragation (a subtype from association) to implement this!

Look at [`SubmittingStudent.cs`](SubmittingStudent.cs) class firstly.
