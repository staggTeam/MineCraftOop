using Oop_tamrin.Models;

var p1 = new Pillager();
p1.Name = "pil1";
var p2 = new Pillager();
p2.Name = "pil2";
p1.Breed(p2);
p1.Show();
p2.Show();
p1.Hit(p2);
p2.kill(p1);
var pig1 = new Piglin();
pig1.Name = "po";
p2.kill(pig1);


