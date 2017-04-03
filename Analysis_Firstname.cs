ѕровер€л и анализировал методы на Java(Math.round, random.nextDouble т.д.)
ќба метода (GetRandomNumber1() и GetRandomNumber2()) почти одинаковые. ” обоих возвращаемое значение double. “олько 
заданные значени€ аргумента метода дл€ округлени€ значени€ разные:
- ¬ методе GetRandomNumber1(): Round((random.NextDouble() - 0.5) * 2);
- ¬ методе GetRandomNumber1(): Round((random.NextDouble() - 0.5) * 2.99);
√лавное отличие это умножение на 2 в первом случае и умножение на 2.99 во втором случае

ѕример:
≈сли задать вместо random.NextDouble() значение 0.7, то:

- метод GetRandomNumber1(): 
(0.7 - 0.5) * 2) = 0.4

- метод GetRandomNumber2(): 
(0.7 - 0.5) * 2.99) = 0.598

 ак известно метод Random округл€ет значение до ближайшего целого, тоесть:
- метод GetRandomNumber1() возвратит значение: 0.0
- метод GetRandomNumber1() возвратит значение: 1.0

 