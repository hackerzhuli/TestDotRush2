## Description
This project tests Dot Rush for Code Navigation in Unity, specifically code navigation to a type in PackageCache.

## What do I mean by PackageCache

When we install a package with Package Manager in Unity, it will stay in Library/PackageCache.

That is not the same as embedded package, which is in Packages directory.

## My Observation
### Dot Rush
For a method from a package(normal package, not embedded), when I click on menu item (for a method in the package) "Go To Definition", it goes to a decompiled source file.

For an embbeded package, it goes to the source file.

### C# Dev Kit
For a normal package, it does go to a decompiled source file.

For an embedded package, it goes to the source file.

### Rider
For a normal package, it goes to the source file inside PackageCache(best experience).

For an embedded package, it goes to the source file.