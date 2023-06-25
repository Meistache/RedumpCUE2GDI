# What's this?

This is a remix of the original RedumpCUE2GDI from [AwfulBear](https://github.com/AwfulBear/RedumpCUE2GDI), using the same set of batch scripts provided in the original release, modified for working with a customized and batch-ready version of [gdi-conversion](https://github.com/Meistache/gdi-conversion-non-destructive-mod) by [sirconan](https://github.com/sirconan/gdi-conversion). 

There are a few reasons for this:
- Avoiding the need of hooking a CLI-based script to a GUI window (which might not work as intented if GUI is not already active)
- Maintenability issues: maintaining C# code requires a lot more resources and this might be costly if you're not a C# developer already. I swear I wanted to contribute to the original C# code but Visual Studio with all the tools is a 50GB download - I might give it another try as soon as I have time to cleanup my C: disk (it's mandatory to have at least 30GB free on it even if you're installing in another drive)
- Easiness to modify the conversion script if necessary - node.js development toolkit requires way less resources than C# toolkit and it's easier to work on your favorite notepad and to re-compile on your terminal console (I don't love JS much to be honest, but this is just true) 

RedumpCUE2GDI is originally based on the app GDIdrop by https://github.com/feyris-tan/

This is program to convert Redump Dreamcast archive BIN/CUE images to GDI images. Unfortunately the only way to use Redump Dreamcast images for some emulators is to convert them to GDI.

You also cannot directly compress a Redump Dreamcast image to create a CHD image! You must convert them to GDI first then convert the GDI to CHD in order for it to be playable. 

The included batch scripts will convert BIN/CUE images -> GDI images or BIN/CUE images -> GDI images -> CHD images which ever you prefer and allows them to become playable on current emulators

Updates to the original gdi-conversion include: 
- Automatically naming track and GDI files instead of generic names that might be overwritten while batch converting
- Using a single folder instead of creating several ones, so we can use chdman right after converting to GDI
Additional Batch Files:
- Allow complete conversion of a Redump Dreamcast archive to GDI or further to CHD using CHDMAN depending on which one you use.
- Don't overwrite files already converted to GDI if they already exist, in case anything goes wrong
- Batch file also helps with clean up of GDI files if you go for the full BIN/CUE -> GDI -> CHD conversion all at once.

# How to use it?
- Redump Dreamcast archive images should be extracted to their own folders. 
- Download the RedumpCUE2GDI.zip from the [releases](https://github.com/Meistache/RedumpCUE2GDI/releases)
- Place the files from RedumpCUE2GDI.zip in the root folder of where all your images are extracted.
- Run the appropriate batch file and follow the on screen instructions

# Legal stuff

The batch files use compiled version of [CHDMAN](https://github.com/mamedev/mame/blob/master/src/tools/chdman.cpp) to compress the GDI images. No changes have been made to CHDMAN. 

This software itself is licensed under [2-clause BSD](https://opensource.org/license/bsd-2-clause/) so it's compatible with the original sources. 

Please only use this software for legally owned games.
