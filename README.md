# Library
Разработать библиотеку, должны быть доступны интерфейс\
IPlugin и класс Plugins (создается в единственном экземпляре):

public interface IPlugin\
{\
string PluginName { get; }\
string Version { get; }\
System.Drawing.Image Image { get; }\
string Description { get; }\
int Run (int input1, int input2);\
}

класс Plugins должен реализовывать интерфейс:\
interface PluginFactory\
{\
int PluginsCount { get; }\
string[] GetPluginNames { get; }\
IPlugin GetPlugin (string pluginName);\
}

Часть реализаций интерфейса IPlugin должна быть унаследована от абстрактного
класса\
Метод Run должен реализовывать различные математические функции (сложение умножение и
т.п.)
