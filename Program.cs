using System.Drawing;

Bitmap temp_img;
Color temp_col;

if (args.Length == 0)
{
    Console.WriteLine("No arguments found.");
}
for (int i = 0; i < args.Length; i++)
    {
    try
    {
        temp_img = (Bitmap)Image.FromFile(args[i]);
        for (int x = 0; x < temp_img.Width; x++)
        {
            for (int y = 0; y < temp_img.Height; y++)
            {
                temp_col = temp_img.GetPixel(x, y);
                temp_col = Color.FromArgb(temp_col.B, temp_col.G, temp_col.R, temp_col.A);
                temp_img.SetPixel(x, y, temp_col);
            }
        }
        temp_img.Save("new_" + args[i]);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
        return;
    }
}

