This is a small console app tha's purpose is to convert an image file to a byte array (for manual insertion into a database). I have use this in the past when working through certain situations when I needed to copy image files and save them into a database as blob storage.

The app can be ran and passed an image file path as an argument, the program will print the byte array and automatically copy it to your clipboard.
dotnet run "C:\FilePath\Image.jpg"
