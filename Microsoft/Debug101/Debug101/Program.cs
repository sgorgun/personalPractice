string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)1;
objs[2] = obj; // ArrayTypeMismatchException occurs