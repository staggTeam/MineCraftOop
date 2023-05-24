using Oop_tamrin.Models;

var steve = new Human();
steve.Name = "Steve";
var alex = new Human();
steve.Name = "Alex";
var child1 = steve.Breed(alex);
child1.Name = "Mitra";
var child2 = steve.Breed(alex);
child2.Name = "Mirak";
child2.kill(child2);


