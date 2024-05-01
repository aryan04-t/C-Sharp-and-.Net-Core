# What is Dependency Injection (DI): 

- In ASP.NET Core, Dependency Injection (DI) is a design pattern and a framework that allows developers to create loosely coupled components within their applications. 

- dependency injection allows you to delegate tasks (dependencies) to specialized components (services), making your code easier to manage and more flexible. 

- In layman terms, if you're hosting a dinner party, then dependency injection is like hiring professionals to handle specific tasks at your dinner party. Instead of trying to do everything yourself, you delegate tasks to experts. This makes your job as the host much easier, as you can focus on making sure your guests are comfortable and enjoying themselves, rather than worrying about cooking and serving the food. 



# Dependency Injection is an Example of "Inversion of Control", Inversion of Control is also a design principle: 

1. Whenever you're writing a code, either you can write all the code from scratch on your own or you can and use some libraries or a framework. 
2. The normal flow of control is when you do everything on your own, you write every piece of code from scratch on your own. 
3. But when we talk about "Inversion of control", this means rather than your code being in charge of creating and managing all its dependencies (like objects it needs to work with), you let a framework or container handle that for you. Your code just focuses on its specific task, while the framework takes care of providing the necessary dependencies. 
4. So, the control which used to be in your hand, that goes from your hands to the frameworks's hand, and this might sound wrong that you don't have enough control over your code, but actually it is not that bad, there are a lot of pros then cons, although if you are okay with doing the extra work and you really want to keep the control in your hands only, then you can go with the normal flow of control, but usually coding doesn't really works like that, rarely you do everything on your own because it is most of the times the most dumb decision to code everything on your own. 
5. But still, it's best to use "Inversion of Control" if you want to build flexible and scalable software systems by doing the least efforts. 
6. Because inversion allows for decoupling of components, making the code more modular, testable, and maintainable. It also promotes separation of concerns, as each component focuses on its specific task without worrying about how its dependencies are created or managed. 