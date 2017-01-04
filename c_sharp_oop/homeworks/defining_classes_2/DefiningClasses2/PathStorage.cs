using System;
using System.Text;
using System.IO;

namespace DefiningClasses2
{
    static class PathStorage
    {
        public static Path LoadPath(string fileLocation)
        {
            Path path = new Path();
            Point3D point = new Point3D();
            string file;
            StringBuilder x = new StringBuilder(), y = new StringBuilder(), z = new StringBuilder();

            StreamReader stream = new StreamReader(fileLocation);
            using (stream)
            {
                try
                {
                    file = stream.ReadToEnd();
                    for (int i = 0; i < file.Length; i++)
                    {
                        // reading one point coordinates
                        while (file[i] != ' ')
                        {
                            x.Append(file[i]);
                            i++;
                        }
                        i++;
                        while (file[i] != ' ')
                        {
                            y.Append(file[i]);
                            i++;
                        }
                        i++;
                        while (file[i] != ' ')
                        {
                            z.Append(file[i]);
                            i++;
                        }
                        i++;
                        point.X = int.Parse(x.ToString());
                        point.Y = int.Parse(y.ToString());
                        point.Z = int.Parse(z.ToString());

                        // adding the point to path
                        path.AddPoint(point);

                        // clearing teamporary point information
                        x.Clear();
                        y.Clear();
                        z.Clear();

                        if (file[i] == '|')
                            break;
                    }
                }
                catch (Exception)
                {
                    throw new Exception("File loading Error !");
                }
                finally
                {
                    stream.Close();
                }
            }
            return path;
        }
        public static void SavePath(Path path, string fileLocation)
        {
            string x = string.Empty;
            string y = string.Empty;
            string z = string.Empty;

            StreamWriter streamWriter = new StreamWriter(fileLocation);

            using (streamWriter)
            {
                try
                {
                    for (int i = 0; i < path.Path1.Count; i++)
                    {
                        //x = path.Path1[i].X.ToString();
                        streamWriter.Write(path.Path1[i].X);
                        streamWriter.Write(' ');
                        //y = path.Path1[i].X.ToString();
                        streamWriter.Write(path.Path1[i].Y);
                        streamWriter.Write(' ');
                        //z = path.Path1[i].X.ToString();
                        streamWriter.Write(path.Path1[i].Z);
                        streamWriter.Write(' ');
                        if (i == path.Path1.Count - 1)
                        {
                            streamWriter.Write('|');
                        }
                        else
                        {
                            streamWriter.Write('/');
                        }
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Saving File Error!");
                }
                finally
                {
                    streamWriter.Close();
                }
            }
        }
    }
}
