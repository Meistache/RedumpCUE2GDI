# What's this?
RedumpCUE2GDI is based on the app GDIdrop by https://github.com/feyris-tan/

This is program to convert Redump Dreamcast archive BIN/CUE images to GDI images. Unfortuantly the only way to use Redump Dreamcast images for some emulators is to convert them to GDI.

You also cannot directly compress a Redump Dreamcast image to create a CHD image! You must convert them to GDI first then convert the GDI to CHD in order for it to be playable. 

The included batch scripts will convert BIN/CUE images -> GDI images or BIN/CUE images -> GDI images -> CHD images which ever you prefer and allows them to become playable on current emulators

Updates to the original program include: 
- The ability to pass a file name to be processed via command line to allow batch jobs.
- Output on file creation status via console when running through a batch script. 
- Organization of the created files into folders that allow for easy removal when completly converting BIN/CUE -> GDI -> CHD. 
- Updated images file resources.

Additional Batch Files:
- Allow complete conversion of a Redump Dreamcast archive to GDI or further to CHD using CHDMAN depending on whih one you use.
- Batch file also helps with clean up of GDI files if you go for the full BIN/CUE -> GDI -> CHD conversion all at once. 

# How to use it?
- Redump Dreamcast archive images should be extracted to their own folders. 
- Download the RedumpCUE2GDI.zip from the [releases](https://github.com/AwfulBear/RedumpCUE2GDI/releases)
- Place the files from RedumpCUE2GDI.zip in the root folder of where all your images are extracted.
- Run the appropriate batch file and follow the on screen instructions

# Legal stuff
This software contains CueSharp licensed under the [2-clause BSD License](https://wyday.com/bsd-license.php)

The batch files use compiled version of [CHDMAN](https://github.com/mamedev/mame/blob/master/src/tools/chdman.cpp) to compress the GDI images. No changes have been made to CHDMAN. 

This software itself is licensed under 2-clause BSD as well. I'm not good with legal stuff either same as the original creator so I am crediting him through out and keeping the same license. 

Please only use this software for legally owned games.
