# Font Awesome Forms
A Modern Example Of Using Fonts & Font Awesome In Xamarin Forms for Pretty & Scalable UI with less bother!



In this repo I will be demonstrating:

- Using Font In Xamarin Forms (The Easy Way)
- Using FontAwesome in Xamarin Forms
- Using Fonts Everywhere:
  - In Navigation Bars
  - In Labels
  - In Images
  - In Tabbed Pages



## Installing Font Awesome (or any fonts 😉)

This repository uses Font Awesome, it includes the free fonts and references (but doesnt not include) the pro fonts. There is no extra setup in this project but you are probably here to understand how to include Font Awesome in your Xamarin Forms. app! 😁

You can download the FontAwesome fonts [here](https://fontawesome.com/download). If you don't have a Pro license select "Free for Desktop"

Once downloaded you should add the font `.otf` files to an appropriate place in your shared project. This repo utilizes the [newer method of using fonts](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/text/fonts) in Forms, which only requires them to be places in the shared project. Gone are the days of putting the fonts in the platform projects, updating `info.plist`'s and having to maintain different `FontFamily` references for each platform type. The font's build action should be set to `EmbeddedResource`.

*You may notice the Font Awesome `.otf` files are named differently in this repository, I did this simply to make their file paths look cleaner*



To make the font available in your app, go to `AssemblyInfo.cs` and add the following code:

```csharp
using Xamarin.Forms;

//Free Fonts
[assembly: ExportFont("FontAwesome5FreeBrands.otf", Alias = "FAFreeBrands")]
[assembly: ExportFont("FontAwesome5FreeRegular.otf", Alias = "FAFreeRegular")]
[assembly: ExportFont("FontAwesome5FreeSolid.otf", Alias = "FAFreeSolid")]
```

This will make each font available under the `Alias` string, so all you need to do is set `FontFamily = "FAFreeBrands"` in order to use Font Awesome! This will of course work for other fonts.



## Font Awesome Pro

I have include examples for both Font Awesome Free & Pro. For obvious reasons I have not included the Font Awesome Pro fonts in this repository, in order to get the pro samples working you will need to perform the following steps:

- Add the Font Awesome Prot `.otf` font files to `src\FontAwesomeForms\Resources\Font Awesome Pro\` as `EmbeddedResource`
- Uncomment the pro pages in `App.xaml.cs`