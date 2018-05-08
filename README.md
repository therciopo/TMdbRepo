## Upcoming Movies Mobile App

[![Build status](https://build.appcenter.ms/v0.1/apps/f82372d6-5de7-48f5-a6bc-09eca436bc21/branches/master/badge)](https://appcenter.ms)


![alt text](https://assets.tmdb.org/images/v4/logos/91x81.png "Logo")

#
#### List of third-party libraries used
- **Xamarin Forms** to create cross-plataform mobile app
- **Autofac** as an IoC Container for Xamarin.Forms
- **NewtonSoft.Json** High-performance JSON framework for .NET to (de)serialize json objects
- **Akavache** An asynchronous, persistent key-value store for desktop and mobile applications on .NET 


#### Screenshots
<img src="TMDbApp\Screenshots\Screenshot_20170419-115519.png" width="150"> <img src="TMDbApp\Screenshots\Screenshot_20170419-115525.png " width="150"> <img src="TMDbApp\Screenshots\Screenshot_20170419-115538.png " width="150">


#### MajorChanges

- Use of FFImageLoading for a cached image and improve speed performance
- Network connection handling
- Enabled of XAML Compilation to:
- Help to reduce the file size of the final assembly.
- Remove some of the load and instantiation time for XAML elements.
- Remove unnecessary bindings
- Layout optimization
- Replace use of RelativeLayout.
- Used * or fixed size on Grids
- AOT Compilation (Experimental) for overall speed up improvement reducing some JIT overhead.
- Link to SDK assemblies only.
- Removed unnecessary packages. 
- Refactorings
- Use of DTO. Decoupling Model from DTO.
- Remove some code duplications
- CleanCode/SOLID
- Class refactoring. Some methods with wrong responsibilities.
- MVVM Improvements
 - Removed remaining Interface/Business Logic coupling replaced by Commands
 - Use of MVVM Navigation. This still can be refactored in order to make the View instantiation
more robust and safe using PRISM or other MVVM Framework that implements navigation.

Thank You

