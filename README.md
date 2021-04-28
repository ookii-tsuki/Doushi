#Doushi Library
Doushi is a library for conjugating Japanese verbs to multiple tenses and forms

| Package |                    NuGet ID                     |                         NuGet Status                         |
| :-----: | :---------------------------------------------: | :----------------------------------------------------------: |
| Kawazu  | [Kawazu]() | [![Stat]()]() |
##Features
* Conjugates Japanese verbs into the forms
	* Non past / Non past polite
	* Past / Past polite
	* Te form
	* Potential
	* Passive
	* Causative
	* Causative Passive
	* Imperative
* Auto detects verb categories

##Usage
###Install
The package can be installed by NuGet:
```powershell
Install-Package Doushi -Version 1.0.0
```
Or reference it in your project:
```xml
<PackageReference Include="Doushi" Version="1.0.0" />
```
###Getting Started
Import the library by spacename
```csharp
using Doushi;
```
Now you can call this static function to conjugate the verb
```csharp
// Will auto detect that this is a Godan verb ending in る and will return its conjugation
var conj = Conjugator.Conjugate("作る", "つくる");
// Manually specifiy the verb type
var conj = Conjugator.Conjugate("作る", Doushi.Type.GODAN_RU, "つくる");
```
The `Conjugate()` function is going to return an `Inflections` class that contains all the verb conjugation in the supported forms, will return null in case the verb is not recognized as a verb
#####Other Public Functions
The `TryFindType()` is a public function that is used by the `Conjugate()` function to try and find the verb type
```csharp
// Will return Type.SPECIAL_KURU
var type = Conjugator.TryFindType("来る", "くる");
```
The `DicToDoushiType()` function is used to convert the supported [JMDict](http://www.edrdg.org/jmdict/edict_doc.html) string types which are ["v1", "v5b", "v5g", "v5k", "v5k-s", "v5m", "v5n", "v5r", "v5r-i", "v5s", "v5t", "v5u", "v5u-s", "vk", "vs-s", "vs-i"] to `Doushi.Type` enum
```csharp
// Will return Type.GODAN_MU
var type = Conjugator.DicToDoushiType("v5m")
```
#####Conjugator Class
Contains the main functions for verb conjugations
#####Inflections
Contains the verb conjugation in all the supported forms
#####Polarity
Contains the verb polarity (Affirmative/Negative) as well as the verb stem reading in case the reading was provided, but always presented for する and 来る verbs

####Example
```csharp
var conj = Conjugator.Conjugate("行く", "いく");
if (conj != null)
{
	Console.WriteLine($"　-> Non-Past: {conj.NonPast.Affirmative} | {conj.NonPast.Negative}\n");
	Console.WriteLine($"　-> Non-Past Polite: {conj.NonPastPolite.Affirmative} | {conj.NonPastPolite.Negative}\n");
	Console.WriteLine($"　-> Past: {conj.Past.Affirmative} | {conj.Past.Negative}\n");
	Console.WriteLine($"　-> Past Polite: {conj.PastPolite.Affirmative} | {conj.PastPolite.Negative}\n");
	Console.WriteLine($"　-> Te Form: {conj.TeForm.Affirmative} | {conj.TeForm.Negative}\n");
	Console.WriteLine($"　-> Potential: {conj.Potential.Affirmative} | {conj.Potential.Negative}\n");
	Console.WriteLine($"　-> Passive: {conj.Passive.Affirmative} | {conj.Passive.Negative}\n");
	Console.WriteLine($"　-> Causative: {conj.Causative.Affirmative} | {conj.Causative.Negative}\n");
	Console.WriteLine($"　-> Causative Passive: {conj.CausativePassive.Affirmative} | {conj.CausativePassive.Negative}\n");
	Console.WriteLine($"　-> Imperative: {conj.Imperative.Affirmative} | {conj.Imperative.Negative}\n");
}
else
{
	Console.WriteLine("Invalid input");                   
}
```
See the Doushi-Example project folder for more info