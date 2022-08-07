//Solving a problem about a dog and two friends - Решаем задачу про собаку и двух друзей
int count = 0; // reset the dog's running counter - обнуляем счетчик беготни собаки
int timeRun = 0; // the time spent on the next run of the dog to a friend - время затраченное на очередную перебежку собаки до друга
int distanceBetween2Friends = 10000; // the initial distance between two friends - начальное расстояние между двумя друзьями
int firstFriendSpeed = 1; // the speed of the first friend - скорость первого друга
int secondFriendSpeed = 2; // the speed of the second friend - скорость второго друга
int dogSpeed = 5; // dog speed - скорость собаки
int numberCurrentFriend = 2; // current friend's pointer - указатель текущего друга
while (distanceBetween2Friends > 10)
{
    if (numberCurrentFriend == 1)
    {
        timeRun = distanceBetween2Friends / (firstFriendSpeed + dogSpeed);
        numberCurrentFriend = 2;
    }
    else 
    {
        timeRun = distanceBetween2Friends / (secondFriendSpeed + dogSpeed);
        numberCurrentFriend = 1;
    }
    distanceBetween2Friends = distanceBetween2Friends - timeRun * (firstFriendSpeed + secondFriendSpeed);
    count++;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");

