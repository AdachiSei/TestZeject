using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            //�v�������\���̂�����̃N���X
            .Bind<IInputtable>()
            //���̃N���X�̃C���X�^���X�𒍓�
            .To<InputFromKeyboard>()
            //�C���X�^���X�̐������@��A������
            .AsSingle();
    }
}