### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Memento pattern
This pattern is useful to take a snapshot of a system, and to be able to restore its (previus state or stack of state). \
The history class mantain the history of originator (our game class). \
The history class and the originator is loosely coupled. \
The memento pattern can use a huge amount of ram, for example if you want backup a state of a video, or a photo. \
The are other types of patter for save the state of a system.