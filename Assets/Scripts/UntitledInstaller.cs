using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            //要求される可能性のあるものクラス
            .Bind<IInputtable>()
            //このクラスのインスタンスを注入
            .To<InputFromKeyboard>()
            //インスタンスの生成方法や、扱い方
            .AsSingle();
    }
}