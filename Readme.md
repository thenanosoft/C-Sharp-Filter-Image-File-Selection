*This is very simple and easy code to select only images files*

![Filter Image Selection ScreenShot](https://i.imgur.com/o5HlShu.png)





## Code:
```C#
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Images *.jpg; *.jpeg; *.gif; *.png; *.bmp; *.tif, *.tiff; | *.jpg; *.jpeg; *.gif; *.png; *.bmp; *.tif, *.tiff;";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgBox.Image = new Bitmap(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Some thing went wrong");
            }
```



Follow Us:
[Website](https://thenanosoft.com)
[Twitter](https://twitter.com/thenanosoft)
[Facebook](https://facebook.com/thenanosoft)
