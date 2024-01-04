// Delegate types are all incompatible with each other, even if their signatures are the same:

D1 d1 = Method1;
D2 d2 = new D2(d1);	// Legal

void Method1() { }

delegate void D1();
delegate void D2();