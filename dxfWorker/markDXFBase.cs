using netDxf;
using netDxf.Entities;
using netDxf.Header;
using netDxf.Tables;

namespace dxfWorker
{
    class markDXFBase
    {
        public static void Convert(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Укажите папку с файлами DXF");
                Console.Write("Для выхода нажмите Enter...");
                Console.Read();
            }
            else
            {
                string str1 = ((IEnumerable<string>)args).ElementAtOrDefault<string>(0);
                if (!Directory.Exists(str1))
                {
                    Console.WriteLine("Указанная папка '{0}' не существует.", (object)str1);
                    Console.Write("Для выхода нажмите Enter...");
                    Console.Read();
                }
                else
                {
                    DxfVersion dxfVersion = DxfVersion.AutoCad2004;
                    switch (((IEnumerable<string>)args).ElementAtOrDefault<string>(1))
                    {
                        case "2010":
                            dxfVersion = DxfVersion.AutoCad2010;
                            break;
                        case "2013":
                            dxfVersion = DxfVersion.AutoCad2013;
                            break;
                        case "2018":
                            dxfVersion = DxfVersion.AutoCad2018;
                            break;
                        case "2007":
                            dxfVersion = DxfVersion.AutoCad2007;
                            break;
                    }
                    string[] array = ((IEnumerable<string>)Directory.GetFiles(str1, "*.dxf")).ToArray<string>();
                    if (array != null && array.Length == 0)
                    {
                        Console.WriteLine("В папке {0} нет DXF-файлов.", (object)str1);
                        Console.Write("Для выхода нажмите Enter...");
                        Console.Read();
                    }
                    else
                    {
                        string name = Directory.GetParent(((IEnumerable<string>)array).FirstOrDefault<string>()).Name;
                        string path = Path.Combine(str1, "CypCut_" + name);
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);
                        foreach (string str2 in array)
                        {
                            if (!File.Exists(str2))
                            {
                                Console.WriteLine("Файл '{0}' не существует.", (object)str2);
                            }
                            else
                            {
                                string withoutExtension = Path.GetFileNameWithoutExtension(str2);
                                string extension = Path.GetExtension(str2);
                                Path.GetDirectoryName(str2);
                                string file = string.Format("{0}\\{1}_({2}){3}", (object)path, (object)withoutExtension, (object)name, (object)extension);
                                List<double> source1 = new List<double>();
                                List<double> source2 = new List<double>();
                                DxfDocument dxfDocument = DxfDocument.Load(str2);
                                if (dxfDocument == null)
                                {
                                    Console.WriteLine("Ошибка загрузки DXF-файла {0}", (object)Path.GetFileName(str2));
                                }
                                else
                                {
                                    dxfDocument.DrawingVariables.AcadVer = dxfVersion;
                                    foreach (Line line in dxfDocument.Entities.Lines)
                                    {
                                        source1.Add(line.StartPoint.X);
                                        source1.Add(line.EndPoint.X);
                                        List<double> doubleList1 = source2;
                                        Vector3 vector3 = line.StartPoint;
                                        double y1 = vector3.Y;
                                        doubleList1.Add(y1);
                                        List<double> doubleList2 = source2;
                                        vector3 = line.EndPoint;
                                        double y2 = vector3.Y;
                                        doubleList2.Add(y2);
                                    }
                                    foreach (Arc arc in dxfDocument.Entities.Arcs)
                                    {
                                        source1.Add(arc.Center.X + arc.Radius);
                                        source1.Add(arc.Center.X - arc.Radius);
                                        source2.Add(arc.Center.Y + arc.Radius);
                                        source2.Add(arc.Center.Y - arc.Radius);
                                    }
                                    if (source1 != null && source1.Count<double>() > 0 && source2 != null && source2.Count<double>() > 0)
                                    {
                                        Layer layer = new Layer("TextOrder");
                                        Text entity = new Text(name);
                                        entity.Layer = layer;
                                        entity.Color = AciColor.Blue;
                                        entity.Style = new TextStyle("iso.shx");
                                        double num1 = 0.0;
                                        double num2 = source1.Max() - source1.Min();
                                        double num3 = source2.Max() - source2.Min();
                                        if (num3 > num2)
                                        {
                                            num1 = 90.0;
                                            entity.Height = 12.0;
                                            entity.Width = entity.Height * 0.4;
                                            int length = name.Length;
                                            double num4 = entity.Height * 0.5;
                                            double num5 = -(num3 * 0.25);
                                            entity.Position = new Vector3(source1.Average() + num4, source2.Average() + num5, 0.0);
                                        }
                                        else
                                        {
                                            entity.Height = 12.0;
                                            double num6 = -(entity.Height * 0.5 * (double)name.Length / 2.0 + num2 * 0.25);
                                            double num7 = -entity.Height / 2.0;
                                            entity.Position = new Vector3(source1.Average() + num6, source2.Average() + num7, 0.0);
                                        }
                                        entity.Rotation = num1;
                                        dxfDocument.Entities.Add((EntityObject)entity);
                                        dxfDocument.Save(file);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}