# What's this?
RedumpCUE2GDI is based on the app GDIdrop by https://github.com/feyris-tan/ 
This a small C# Program to convert Redump Dreamcast archive BIN/CUE images to GDI images. Unfortuantly the only way to use Redump Dreamcast images for some emulators is to convert them to GDI.

You also cannot directly compress a Redump Dreamcast image to create a CHD image! You must convert them to GDI first then convert the GDI to CHD in order for it to be playable. 

The included batch scripts will convert BIN/CUE images -> GDI images or BIN/CUE images -> GDI images -> CHD images which ever you prefer and allows them to become playable on current emulators

Updates to the original program include: 
- The ability to pass a file name to be processed via command line to allow batch jobs.
- Output on file creation status via console when running through a batch script. 
- Organization of the created files into folders that allow for easy removal when converting completly from BIN/CUE to GDI to CHD. 
- Updated images file resources.

Additional Batch Files:
- Allow complete conversion of a Redump Dreamcast archive to GDI or further to CHD using CHDMAN depending on whih one you use.
- Batch file also helps with clean up of GDI files if you go for the full BIN/CUE -> GDI -> CHD conversion all at once. 

# How to use it?
- Redump Dreamcast archive images should be extracted to their own folders.
- Download the RedumpCUE2GDI.zip
- Place the files from RedumpCUE2GDI.zip in the root folder of where all your images are extracted.
- Run the appropriate batch file and follow the on screen instructions

# Legal stuff
This software contains CueSharp licensed under the 2-clause BSD License found here: [here](https://wyday.com/bsd-license.php)

This software itself it license under 2-clause BSD as well. I'm not good with legal stuff either liek the original creator so I am crediting him through out and keepign the same license. 
