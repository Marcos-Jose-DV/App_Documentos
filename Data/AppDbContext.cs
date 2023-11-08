using AppDocuments.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocuments.Data;

public class AppDbContext
{
    //public List<Category> GetCategories()
    //{
    //    List<Category> category = new()
    //    {

    //        new Category()
    //        {

               
    //            Name = "Asp NET.",
    //            Components = new List<Component>
    //            {
    //                new Component
    //                {
                       
    //                    Title = "SqlServe DbContext",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                },
    //                new Component
    //                {
                      
    //                    Title = "Criando Controller",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                },
    //                new Component
    //                {
                        
    //                    Title = "Criar Mapeamento",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                }
    //            }
    //        },
    //         new Category()
    //        {

              
    //            Name = "Test2",
    //            Components = new List<Component>
    //            {
    //                new Component
    //                {
                       
    //                    Title = "Test2",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                },
    //                new Component
    //                {
                       
    //                    Title = "Criando Controller",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                },
    //                new Component
    //                {
                     
    //                    Title = "Criar Mapeamento",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                }
    //            }
    //        },
    //        new Category()
    //        {

                
    //            Name = "Test3",
    //            Components = new List<Component>
    //            {
    //                new Component
    //                {
                       
    //                    Title = "Test3",
    //                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut convallis, risus at convallis convallis, quam lacus pellentesque felis, sit amet vulputate libero nisi in felis. In quis diam eu augue dignissim auctor vel non velit. Maecenas porttitor suscipit ultrices. In aliquam gravida arcu vitae pretium. In hac habitasse platea dictumst. Nulla dignissim metus ante. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur non erat sit amet purus semper rhoncus. Suspendisse ac ipsum at lectus pretium ullamcorper eget at leo. Mauris posuere turpis ipsum, ut dapibus erat vestibulum at. Vivamus eleifend arcu et gravida faucibus. Ut interdum sodales lectus.\r\n\r\nMaecenas fermentum ac mi sit amet aliquet. Nam sagittis porta ligula ac ultricies. Maecenas sit amet est ipsum. Integer eleifend sapien vitae massa molestie sollicitudin. Nulla vitae leo sit amet metus commodo dignissim. Pellentesque vel orci dapibus, sagittis est quis, consectetur risus. Donec pharetra lorem a tincidunt porta. Fusce nec justo eleifend, rutrum mi iaculis, mattis nisl. Morbi ullamcorper lorem vitae lacus tempor luctus. Sed feugiat vel nibh et accumsan. Integer sit amet iaculis quam. Duis commodo eleifend arcu, at pharetra tellus euismod luctus. Nunc hendrerit accumsan urna. Sed quam nisl, porttitor et dapibus ut, ullamcorper vel diam.\r\n\r\nProin egestas sed justo vitae volutpat. Ut condimentum lobortis purus sed lobortis. Aliquam aliquet augue ut dignissim laoreet. Aliquam facilisis vehicula leo, sit amet suscipit nisl vehicula ut. In quis turpis vitae mauris accumsan bibendum. Phasellus ac nisi eu libero sollicitudin sodales non a enim. Morbi posuere ultrices justo ac elementum. Donec porttitor euismod mauris, id iaculis justo tempus eu. Pellentesque convallis eros nulla, eget lobortis eros varius non. Morbi lacinia leo ex, id sollicitudin elit volutpat eget. Pellentesque nulla massa, congue vel placerat quis, sagittis vitae tellus. Phasellus dignissim enim mauris, at vulputate neque imperdiet vel. Fusce diam libero, semper rutrum semper ut, pretium quis neque. Nullam nec lectus quis dolor vehicula varius eu in diam. Duis varius orci eu pulvinar tempus. Sed elementum, enim lacinia accumsan molestie, elit ante gravida justo, sit amet blandit libero ante non justo.\r\n\r\nSed nec massa at purus venenatis bibendum at ut mi. Etiam rutrum orci risus, quis ultrices neque vulputate nec. In eget lorem mi. Etiam vulputate metus enim, pharetra scelerisque felis vestibulum id. Sed congue consectetur augue placerat viverra. Curabitur fermentum, lectus non pretium porta, risus mi efficitur magna, nec tincidunt sem mauris non purus. Vivamus tempus semper tincidunt. Nullam iaculis lacus ut tortor maximus mattis. Nullam lorem lacus, maximus eu volutpat a, vulputate quis ex. Nulla egestas magna in massa auctor venenatis. Integer maximus euismod mauris vel elementum. Morbi eu tempus nisi. Maecenas quis tortor viverra, interdum ex nec, congue ex.\r\n\r\nFusce pulvinar nec ipsum sit amet pharetra. Maecenas viverra ex eu massa imperdiet vulputate. Quisque fringilla ullamcorper ex, a eleifend neque. Curabitur eget vestibulum ipsum. Quisque sit amet bibendum leo. Vestibulum vitae eros et ante rutrum placerat. Aliquam ante lectus, maximus id aliquet id, egestas vel massa. Quisque consectetur lacus a luctus vulputate. Sed sed erat turpis. Quisque pretium efficitur velit, ut mollis augue lacinia nec. Praesent ultrices, ligula eget posuere auctor, nulla mauris luctus augue, sit amet efficitur velit tortor sit amet dui. Nunc eget urna id erat lacinia mattis et id ex. Aenean sit amet blandit lacus. Integer eget nulla nunc. Suspendisse lacinia sagittis sem. Nam nec mi mi.\r\n\r\nQuisque vel aliquet augue. In mollis egestas felis vitae vehicula. Ut id ante non urna semper bibendum eu id nibh. Donec elementum pharetra dictum. Quisque commodo augue ut ipsum imperdiet, non luctus felis tristique. Donec vulputate vel sem a condimentum. Pellentesque volutpat ligula a magna bibendum imperdiet. Morbi finibus sapien ac neque lacinia, sed elementum lacus efficitur. Cras malesuada tellus eu vestibulum vehicula. Quisque ac erat nec metus consectetur pellentesque a viverra ligula. Donec tincidunt mauris vel egestas blandit. Morbi tempor a elit sed bibendum.\r\n\r\nCras ultricies tellus nec leo ultricies sodales. Phasellus nec massa at tellus blandit aliquam nec ut eros. Nullam vulputate auctor diam sed viverra. Nunc tortor nibh, pulvinar in lacus non, ornare ullamcorper massa. Cras pretium felis justo, sit amet sollicitudin nisi fermentum id. Fusce dui nunc, malesuada et dui vitae, condimentum sollicitudin sem. Sed non metus non magna maximus molestie at sed justo. Duis mattis, nisi sed sollicitudin consectetur, ante neque ultricies velit, a bibendum libero nulla quis lacus. Phasellus gravida quis nunc sed ultricies. Etiam pulvinar ultricies dolor. Curabitur facilisis semper ornare.\r\n\r\nAenean sit amet dolor a mi tristique maximus. Proin consequat malesuada lacus, a scelerisque nisi condimentum id. Mauris scelerisque, nibh vel maximus semper, ligula neque eleifend dolor, vel sagittis ipsum orci in risus. Vestibulum nisi tortor, egestas pulvinar mauris a, viverra lacinia lacus. Nunc consequat enim vel euismod pellentesque. Nullam placerat nec risus eget fermentum. Suspendisse tincidunt lacus orci, eu blandit sem semper eu. Vestibulum ac arcu dolor. Ut eu massa eros. Cras sed semper tellus. Fusce convallis urna placerat, sodales velit ac, tincidunt magna. Nam rhoncus maximus nulla id pharetra. Vestibulum hendrerit urna vel ipsum volutpat cursus eget a eros.\r\n\r\nEtiam malesuada augue ac ligula efficitur, in semper libero venenatis. Nunc in neque ac arcu feugiat consequat. Praesent sem metus, semper at eros vitae, feugiat egestas tortor. Nam semper a dui sit amet commodo. Vivamus elementum non risus eu aliquam. In vel ullamcorper metus, ut ultrices elit. Fusce a lorem semper, cursus arcu eget, congue purus.\r\n\r\nQuisque vitae sapien malesuada, eleifend ante in, malesuada felis. Donec euismod, est at elementum auctor, dui lacus feugiat arcu, vitae laoreet lorem odio lacinia metus. Nulla justo massa, lobortis sed pretium pretium, porttitor eget lectus. Aliquam magna est, vulputate in tristique ut, mollis vitae augue. Morbi fermentum mattis luctus. Proin in tellus at ligula blandit semper. Etiam a pellentesque nibh. Sed venenatis sem ac sapien consectetur mattis. Nunc a molestie quam. Nullam ac blandit sem.\r\n\r\nGenerated 10 paragraphs, 963 words, 6426 bytes of Lorem Ipsum",

    //                },
    //                new Component
    //                {
                      
    //                    Title = "Criando Controller",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                },
    //                new Component
    //                {
                       
    //                    Title = "Criar Mapeamento",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                }
    //            }
    //        },
    //        new Category()
    //        {

              
    //            Name = "Test4",
    //            Components = new List<Component>
    //            {
    //                new Component
    //                {
                      
    //                    Title = "Test3",
    //                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut convallis, risus at convallis convallis, quam lacus pellentesque felis, sit amet vulputate libero nisi in felis. In quis diam eu augue dignissim auctor vel non velit. Maecenas porttitor suscipit ultrices. In aliquam gravida arcu vitae pretium. In hac habitasse platea dictumst. Nulla dignissim metus ante. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur non erat sit amet purus semper rhoncus. Suspendisse ac ipsum at lectus pretium ullamcorper eget at leo. Mauris posuere turpis ipsum, ut dapibus erat vestibulum at. Vivamus eleifend arcu et gravida faucibus. Ut interdum sodales lectus.\r\n\r\nMaecenas fermentum ac mi sit amet aliquet. Nam sagittis porta ligula ac ultricies. Maecenas sit amet est ipsum. Integer eleifend sapien vitae massa molestie sollicitudin. Nulla vitae leo sit amet metus commodo dignissim. Pellentesque vel orci dapibus, sagittis est quis, consectetur risus. Donec pharetra lorem a tincidunt porta. Fusce nec justo eleifend, rutrum mi iaculis, mattis nisl. Morbi ullamcorper lorem vitae lacus tempor luctus. Sed feugiat vel nibh et accumsan. Integer sit amet iaculis quam. Duis commodo eleifend arcu, at pharetra tellus euismod luctus. Nunc hendrerit accumsan urna. Sed quam nisl, porttitor et dapibus ut, ullamcorper vel diam.\r\n\r\nProin egestas sed justo vitae volutpat. Ut condimentum lobortis purus sed lobortis. Aliquam aliquet augue ut dignissim laoreet. Aliquam facilisis vehicula leo, sit amet suscipit nisl vehicula ut. In quis turpis vitae mauris accumsan bibendum. Phasellus ac nisi eu libero sollicitudin sodales non a enim. Morbi posuere ultrices justo ac elementum. Donec porttitor euismod mauris, id iaculis justo tempus eu. Pellentesque convallis eros nulla, eget lobortis eros varius non. Morbi lacinia leo ex, id sollicitudin elit volutpat eget. Pellentesque nulla massa, congue vel placerat quis, sagittis vitae tellus. Phasellus dignissim enim mauris, at vulputate neque imperdiet vel. Fusce diam libero, semper rutrum semper ut, pretium quis neque. Nullam nec lectus quis dolor vehicula varius eu in diam. Duis varius orci eu pulvinar tempus. Sed elementum, enim lacinia accumsan molestie, elit ante gravida justo, sit amet blandit libero ante non justo.\r\n\r\nSed nec massa at purus venenatis bibendum at ut mi. Etiam rutrum orci risus, quis ultrices neque vulputate nec. In eget lorem mi. Etiam vulputate metus enim, pharetra scelerisque felis vestibulum id. Sed congue consectetur augue placerat viverra. Curabitur fermentum, lectus non pretium porta, risus mi efficitur magna, nec tincidunt sem mauris non purus. Vivamus tempus semper tincidunt. Nullam iaculis lacus ut tortor maximus mattis. Nullam lorem lacus, maximus eu volutpat a, vulputate quis ex. Nulla egestas magna in massa auctor venenatis. Integer maximus euismod mauris vel elementum. Morbi eu tempus nisi. Maecenas quis tortor viverra, interdum ex nec, congue ex.\r\n\r\nFusce pulvinar nec ipsum sit amet pharetra. Maecenas viverra ex eu massa imperdiet vulputate. Quisque fringilla ullamcorper ex, a eleifend neque. Curabitur eget vestibulum ipsum. Quisque sit amet bibendum leo. Vestibulum vitae eros et ante rutrum placerat. Aliquam ante lectus, maximus id aliquet id, egestas vel massa. Quisque consectetur lacus a luctus vulputate. Sed sed erat turpis. Quisque pretium efficitur velit, ut mollis augue lacinia nec. Praesent ultrices, ligula eget posuere auctor, nulla mauris luctus augue, sit amet efficitur velit tortor sit amet dui. Nunc eget urna id erat lacinia mattis et id ex. Aenean sit amet blandit lacus. Integer eget nulla nunc. Suspendisse lacinia sagittis sem. Nam nec mi mi.\r\n\r\nQuisque vel aliquet augue. In mollis egestas felis vitae vehicula. Ut id ante non urna semper bibendum eu id nibh. Donec elementum pharetra dictum. Quisque commodo augue ut ipsum imperdiet, non luctus felis tristique. Donec vulputate vel sem a condimentum. Pellentesque volutpat ligula a magna bibendum imperdiet. Morbi finibus sapien ac neque lacinia, sed elementum lacus efficitur. Cras malesuada tellus eu vestibulum vehicula. Quisque ac erat nec metus consectetur pellentesque a viverra ligula. Donec tincidunt mauris vel egestas blandit. Morbi tempor a elit sed bibendum.\r\n\r\nCras ultricies tellus nec leo ultricies sodales. Phasellus nec massa at tellus blandit aliquam nec ut eros. Nullam vulputate auctor diam sed viverra. Nunc tortor nibh, pulvinar in lacus non, ornare ullamcorper massa. Cras pretium felis justo, sit amet sollicitudin nisi fermentum id. Fusce dui nunc, malesuada et dui vitae, condimentum sollicitudin sem. Sed non metus non magna maximus molestie at sed justo. Duis mattis, nisi sed sollicitudin consectetur, ante neque ultricies velit, a bibendum libero nulla quis lacus. Phasellus gravida quis nunc sed ultricies. Etiam pulvinar ultricies dolor. Curabitur facilisis semper ornare.\r\n\r\nAenean sit amet dolor a mi tristique maximus. Proin consequat malesuada lacus, a scelerisque nisi condimentum id. Mauris scelerisque, nibh vel maximus semper, ligula neque eleifend dolor, vel sagittis ipsum orci in risus. Vestibulum nisi tortor, egestas pulvinar mauris a, viverra lacinia lacus. Nunc consequat enim vel euismod pellentesque. Nullam placerat nec risus eget fermentum. Suspendisse tincidunt lacus orci, eu blandit sem semper eu. Vestibulum ac arcu dolor. Ut eu massa eros. Cras sed semper tellus. Fusce convallis urna placerat, sodales velit ac, tincidunt magna. Nam rhoncus maximus nulla id pharetra. Vestibulum hendrerit urna vel ipsum volutpat cursus eget a eros.\r\n\r\nEtiam malesuada augue ac ligula efficitur, in semper libero venenatis. Nunc in neque ac arcu feugiat consequat. Praesent sem metus, semper at eros vitae, feugiat egestas tortor. Nam semper a dui sit amet commodo. Vivamus elementum non risus eu aliquam. In vel ullamcorper metus, ut ultrices elit. Fusce a lorem semper, cursus arcu eget, congue purus.\r\n\r\nQuisque vitae sapien malesuada, eleifend ante in, malesuada felis. Donec euismod, est at elementum auctor, dui lacus feugiat arcu, vitae laoreet lorem odio lacinia metus. Nulla justo massa, lobortis sed pretium pretium, porttitor eget lectus. Aliquam magna est, vulputate in tristique ut, mollis vitae augue. Morbi fermentum mattis luctus. Proin in tellus at ligula blandit semper. Etiam a pellentesque nibh. Sed venenatis sem ac sapien consectetur mattis. Nunc a molestie quam. Nullam ac blandit sem.\r\n\r\nGenerated 10 paragraphs, 963 words, 6426 bytes of Lorem Ipsum",
    //                },
    //                new Component
    //                {

                       
    //                    Title = "Criando Controller",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                },
    //                new Component
    //                {

                       
    //                    Title = "Criar Mapeamento",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                }
    //            }
    //        },
    //        new Category()
    //        {

             
    //            Name = "Test5",
    //            Components = new List<Component>
    //            {
    //                new Component
    //                {

                       
    //                    Title = "Test3",
    //                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut convallis, risus at convallis convallis, quam lacus pellentesque felis, sit amet vulputate libero nisi in felis. In quis diam eu augue dignissim auctor vel non velit. Maecenas porttitor suscipit ultrices. In aliquam gravida arcu vitae pretium. In hac habitasse platea dictumst. Nulla dignissim metus ante. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur non erat sit amet purus semper rhoncus. Suspendisse ac ipsum at lectus pretium ullamcorper eget at leo. Mauris posuere turpis ipsum, ut dapibus erat vestibulum at. Vivamus eleifend arcu et gravida faucibus. Ut interdum sodales lectus.\r\n\r\nMaecenas fermentum ac mi sit amet aliquet. Nam sagittis porta ligula ac ultricies. Maecenas sit amet est ipsum. Integer eleifend sapien vitae massa molestie sollicitudin. Nulla vitae leo sit amet metus commodo dignissim. Pellentesque vel orci dapibus, sagittis est quis, consectetur risus. Donec pharetra lorem a tincidunt porta. Fusce nec justo eleifend, rutrum mi iaculis, mattis nisl. Morbi ullamcorper lorem vitae lacus tempor luctus. Sed feugiat vel nibh et accumsan. Integer sit amet iaculis quam. Duis commodo eleifend arcu, at pharetra tellus euismod luctus. Nunc hendrerit accumsan urna. Sed quam nisl, porttitor et dapibus ut, ullamcorper vel diam.\r\n\r\nProin egestas sed justo vitae volutpat. Ut condimentum lobortis purus sed lobortis. Aliquam aliquet augue ut dignissim laoreet. Aliquam facilisis vehicula leo, sit amet suscipit nisl vehicula ut. In quis turpis vitae mauris accumsan bibendum. Phasellus ac nisi eu libero sollicitudin sodales non a enim. Morbi posuere ultrices justo ac elementum. Donec porttitor euismod mauris, id iaculis justo tempus eu. Pellentesque convallis eros nulla, eget lobortis eros varius non. Morbi lacinia leo ex, id sollicitudin elit volutpat eget. Pellentesque nulla massa, congue vel placerat quis, sagittis vitae tellus. Phasellus dignissim enim mauris, at vulputate neque imperdiet vel. Fusce diam libero, semper rutrum semper ut, pretium quis neque. Nullam nec lectus quis dolor vehicula varius eu in diam. Duis varius orci eu pulvinar tempus. Sed elementum, enim lacinia accumsan molestie, elit ante gravida justo, sit amet blandit libero ante non justo.\r\n\r\nSed nec massa at purus venenatis bibendum at ut mi. Etiam rutrum orci risus, quis ultrices neque vulputate nec. In eget lorem mi. Etiam vulputate metus enim, pharetra scelerisque felis vestibulum id. Sed congue consectetur augue placerat viverra. Curabitur fermentum, lectus non pretium porta, risus mi efficitur magna, nec tincidunt sem mauris non purus. Vivamus tempus semper tincidunt. Nullam iaculis lacus ut tortor maximus mattis. Nullam lorem lacus, maximus eu volutpat a, vulputate quis ex. Nulla egestas magna in massa auctor venenatis. Integer maximus euismod mauris vel elementum. Morbi eu tempus nisi. Maecenas quis tortor viverra, interdum ex nec, congue ex.\r\n\r\nFusce pulvinar nec ipsum sit amet pharetra. Maecenas viverra ex eu massa imperdiet vulputate. Quisque fringilla ullamcorper ex, a eleifend neque. Curabitur eget vestibulum ipsum. Quisque sit amet bibendum leo. Vestibulum vitae eros et ante rutrum placerat. Aliquam ante lectus, maximus id aliquet id, egestas vel massa. Quisque consectetur lacus a luctus vulputate. Sed sed erat turpis. Quisque pretium efficitur velit, ut mollis augue lacinia nec. Praesent ultrices, ligula eget posuere auctor, nulla mauris luctus augue, sit amet efficitur velit tortor sit amet dui. Nunc eget urna id erat lacinia mattis et id ex. Aenean sit amet blandit lacus. Integer eget nulla nunc. Suspendisse lacinia sagittis sem. Nam nec mi mi.\r\n\r\nQuisque vel aliquet augue. In mollis egestas felis vitae vehicula. Ut id ante non urna semper bibendum eu id nibh. Donec elementum pharetra dictum. Quisque commodo augue ut ipsum imperdiet, non luctus felis tristique. Donec vulputate vel sem a condimentum. Pellentesque volutpat ligula a magna bibendum imperdiet. Morbi finibus sapien ac neque lacinia, sed elementum lacus efficitur. Cras malesuada tellus eu vestibulum vehicula. Quisque ac erat nec metus consectetur pellentesque a viverra ligula. Donec tincidunt mauris vel egestas blandit. Morbi tempor a elit sed bibendum.\r\n\r\nCras ultricies tellus nec leo ultricies sodales. Phasellus nec massa at tellus blandit aliquam nec ut eros. Nullam vulputate auctor diam sed viverra. Nunc tortor nibh, pulvinar in lacus non, ornare ullamcorper massa. Cras pretium felis justo, sit amet sollicitudin nisi fermentum id. Fusce dui nunc, malesuada et dui vitae, condimentum sollicitudin sem. Sed non metus non magna maximus molestie at sed justo. Duis mattis, nisi sed sollicitudin consectetur, ante neque ultricies velit, a bibendum libero nulla quis lacus. Phasellus gravida quis nunc sed ultricies. Etiam pulvinar ultricies dolor. Curabitur facilisis semper ornare.\r\n\r\nAenean sit amet dolor a mi tristique maximus. Proin consequat malesuada lacus, a scelerisque nisi condimentum id. Mauris scelerisque, nibh vel maximus semper, ligula neque eleifend dolor, vel sagittis ipsum orci in risus. Vestibulum nisi tortor, egestas pulvinar mauris a, viverra lacinia lacus. Nunc consequat enim vel euismod pellentesque. Nullam placerat nec risus eget fermentum. Suspendisse tincidunt lacus orci, eu blandit sem semper eu. Vestibulum ac arcu dolor. Ut eu massa eros. Cras sed semper tellus. Fusce convallis urna placerat, sodales velit ac, tincidunt magna. Nam rhoncus maximus nulla id pharetra. Vestibulum hendrerit urna vel ipsum volutpat cursus eget a eros.\r\n\r\nEtiam malesuada augue ac ligula efficitur, in semper libero venenatis. Nunc in neque ac arcu feugiat consequat. Praesent sem metus, semper at eros vitae, feugiat egestas tortor. Nam semper a dui sit amet commodo. Vivamus elementum non risus eu aliquam. In vel ullamcorper metus, ut ultrices elit. Fusce a lorem semper, cursus arcu eget, congue purus.\r\n\r\nQuisque vitae sapien malesuada, eleifend ante in, malesuada felis. Donec euismod, est at elementum auctor, dui lacus feugiat arcu, vitae laoreet lorem odio lacinia metus. Nulla justo massa, lobortis sed pretium pretium, porttitor eget lectus. Aliquam magna est, vulputate in tristique ut, mollis vitae augue. Morbi fermentum mattis luctus. Proin in tellus at ligula blandit semper. Etiam a pellentesque nibh. Sed venenatis sem ac sapien consectetur mattis. Nunc a molestie quam. Nullam ac blandit sem.\r\n\r\nGenerated 10 paragraphs, 963 words, 6426 bytes of Lorem Ipsum",

    //                },
    //                new Component
    //                {
                     
    //                    Title = "Criando Controller",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                },
    //                new Component
    //                {

    //                    Title = "Criar Mapeamento",
    //                    Description = "Organiza os elementos dentro de uma tabela",

    //                }
    //            }
    //        },
    //        new Category()
    //        {

              
    //            Name = "Test6",
    //            Components = new List<Component>
    //            {
    //                new Component
    //                {

                        
    //                    Title = "Test3",
    //                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut convallis, risus at convallis convallis, quam lacus pellentesque felis, sit amet vulputate libero nisi in felis. In quis diam eu augue dignissim auctor vel non velit. Maecenas porttitor suscipit ultrices. In aliquam gravida arcu vitae pretium. In hac habitasse platea dictumst. Nulla dignissim metus ante. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur non erat sit amet purus semper rhoncus. Suspendisse ac ipsum at lectus pretium ullamcorper eget at leo. Mauris posuere turpis ipsum, ut dapibus erat vestibulum at. Vivamus eleifend arcu et gravida faucibus. Ut interdum sodales lectus.\r\n\r\nMaecenas fermentum ac mi sit amet aliquet. Nam sagittis porta ligula ac ultricies. Maecenas sit amet est ipsum. Integer eleifend sapien vitae massa molestie sollicitudin. Nulla vitae leo sit amet metus commodo dignissim. Pellentesque vel orci dapibus, sagittis est quis, consectetur risus. Donec pharetra lorem a tincidunt porta. Fusce nec justo eleifend, rutrum mi iaculis, mattis nisl. Morbi ullamcorper lorem vitae lacus tempor luctus. Sed feugiat vel nibh et accumsan. Integer sit amet iaculis quam. Duis commodo eleifend arcu, at pharetra tellus euismod luctus. Nunc hendrerit accumsan urna. Sed quam nisl, porttitor et dapibus ut, ullamcorper vel diam.\r\n\r\nProin egestas sed justo vitae volutpat. Ut condimentum lobortis purus sed lobortis. Aliquam aliquet augue ut dignissim laoreet. Aliquam facilisis vehicula leo, sit amet suscipit nisl vehicula ut. In quis turpis vitae mauris accumsan bibendum. Phasellus ac nisi eu libero sollicitudin sodales non a enim. Morbi posuere ultrices justo ac elementum. Donec porttitor euismod mauris, id iaculis justo tempus eu. Pellentesque convallis eros nulla, eget lobortis eros varius non. Morbi lacinia leo ex, id sollicitudin elit volutpat eget. Pellentesque nulla massa, congue vel placerat quis, sagittis vitae tellus. Phasellus dignissim enim mauris, at vulputate neque imperdiet vel. Fusce diam libero, semper rutrum semper ut, pretium quis neque. Nullam nec lectus quis dolor vehicula varius eu in diam. Duis varius orci eu pulvinar tempus. Sed elementum, enim lacinia accumsan molestie, elit ante gravida justo, sit amet blandit libero ante non justo.\r\n\r\nSed nec massa at purus venenatis bibendum at ut mi. Etiam rutrum orci risus, quis ultrices neque vulputate nec. In eget lorem mi. Etiam vulputate metus enim, pharetra scelerisque felis vestibulum id. Sed congue consectetur augue placerat viverra. Curabitur fermentum, lectus non pretium porta, risus mi efficitur magna, nec tincidunt sem mauris non purus. Vivamus tempus semper tincidunt. Nullam iaculis lacus ut tortor maximus mattis. Nullam lorem lacus, maximus eu volutpat a, vulputate quis ex. Nulla egestas magna in massa auctor venenatis. Integer maximus euismod mauris vel elementum. Morbi eu tempus nisi. Maecenas quis tortor viverra, interdum ex nec, congue ex.\r\n\r\nFusce pulvinar nec ipsum sit amet pharetra. Maecenas viverra ex eu massa imperdiet vulputate. Quisque fringilla ullamcorper ex, a eleifend neque. Curabitur eget vestibulum ipsum. Quisque sit amet bibendum leo. Vestibulum vitae eros et ante rutrum placerat. Aliquam ante lectus, maximus id aliquet id, egestas vel massa. Quisque consectetur lacus a luctus vulputate. Sed sed erat turpis. Quisque pretium efficitur velit, ut mollis augue lacinia nec. Praesent ultrices, ligula eget posuere auctor, nulla mauris luctus augue, sit amet efficitur velit tortor sit amet dui. Nunc eget urna id erat lacinia mattis et id ex. Aenean sit amet blandit lacus. Integer eget nulla nunc. Suspendisse lacinia sagittis sem. Nam nec mi mi.\r\n\r\nQuisque vel aliquet augue. In mollis egestas felis vitae vehicula. Ut id ante non urna semper bibendum eu id nibh. Donec elementum pharetra dictum. Quisque commodo augue ut ipsum imperdiet, non luctus felis tristique. Donec vulputate vel sem a condimentum. Pellentesque volutpat ligula a magna bibendum imperdiet. Morbi finibus sapien ac neque lacinia, sed elementum lacus efficitur. Cras malesuada tellus eu vestibulum vehicula. Quisque ac erat nec metus consectetur pellentesque a viverra ligula. Donec tincidunt mauris vel egestas blandit. Morbi tempor a elit sed bibendum.\r\n\r\nCras ultricies tellus nec leo ultricies sodales. Phasellus nec massa at tellus blandit aliquam nec ut eros. Nullam vulputate auctor diam sed viverra. Nunc tortor nibh, pulvinar in lacus non, ornare ullamcorper massa. Cras pretium felis justo, sit amet sollicitudin nisi fermentum id. Fusce dui nunc, malesuada et dui vitae, condimentum sollicitudin sem. Sed non metus non magna maximus molestie at sed justo. Duis mattis, nisi sed sollicitudin consectetur, ante neque ultricies velit, a bibendum libero nulla quis lacus. Phasellus gravida quis nunc sed ultricies. Etiam pulvinar ultricies dolor. Curabitur facilisis semper ornare.\r\n\r\nAenean sit amet dolor a mi tristique maximus. Proin consequat malesuada lacus, a scelerisque nisi condimentum id. Mauris scelerisque, nibh vel maximus semper, ligula neque eleifend dolor, vel sagittis ipsum orci in risus. Vestibulum nisi tortor, egestas pulvinar mauris a, viverra lacinia lacus. Nunc consequat enim vel euismod pellentesque. Nullam placerat nec risus eget fermentum. Suspendisse tincidunt lacus orci, eu blandit sem semper eu. Vestibulum ac arcu dolor. Ut eu massa eros. Cras sed semper tellus. Fusce convallis urna placerat, sodales velit ac, tincidunt magna. Nam rhoncus maximus nulla id pharetra. Vestibulum hendrerit urna vel ipsum volutpat cursus eget a eros.\r\n\r\nEtiam malesuada augue ac ligula efficitur, in semper libero venenatis. Nunc in neque ac arcu feugiat consequat. Praesent sem metus, semper at eros vitae, feugiat egestas tortor. Nam semper a dui sit amet commodo. Vivamus elementum non risus eu aliquam. In vel ullamcorper metus, ut ultrices elit. Fusce a lorem semper, cursus arcu eget, congue purus.\r\n\r\nQuisque vitae sapien malesuada, eleifend ante in, malesuada felis. Donec euismod, est at elementum auctor, dui lacus feugiat arcu, vitae laoreet lorem odio lacinia metus. Nulla justo massa, lobortis sed pretium pretium, porttitor eget lectus. Aliquam magna est, vulputate in tristique ut, mollis vitae augue. Morbi fermentum mattis luctus. Proin in tellus at ligula blandit semper. Etiam a pellentesque nibh. Sed venenatis sem ac sapien consectetur mattis. Nunc a molestie quam. Nullam ac blandit sem.\r\n\r\nGenerated 10 paragraphs, 963 words, 6426 bytes of Lorem Ipsum",
    //                },
    //                new Component
    //                {
                       
    //                    Title = "Criando Controller",
    //                    Description = "Organiza os elementos dentro de uma tabela",
    //                },
    //                new Component
    //                {

                       
    //                    Title = "Criar Mapeamento",
    //                    Description = "Organiza os elementos dentro de uma tabela",
    //                }
    //            }
    //        },

    //    };

    //    return category;
    //}
}
