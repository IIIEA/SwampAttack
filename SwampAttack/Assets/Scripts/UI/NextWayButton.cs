using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextWayButton : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Button _nextWaveButton;

    private void OnEnable()
    {
        _spawner.AllEnemiesSpawned += OnAllEmeiesSpawned;
        _nextWaveButton.onClick.AddListener(OnNextWaveButtonClick);
    }

    private void OnDisable()
    {
        _spawner.AllEnemiesSpawned -= OnAllEmeiesSpawned;
        _nextWaveButton.onClick.RemoveListener(OnNextWaveButtonClick);
    }

    public void OnNextWaveButtonClick()
    {
        _spawner.SpawnNextWave();
        _nextWaveButton.gameObject.SetActive(false);
    }

    private void OnAllEmeiesSpawned()
    {
        _nextWaveButton.gameObject.SetActive(true);
    }
}
