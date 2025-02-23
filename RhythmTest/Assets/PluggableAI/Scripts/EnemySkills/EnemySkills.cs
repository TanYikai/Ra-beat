﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemySkills {
    private int chargeRequired;

    public EnemySkills(int chargeRequired) {
        this.chargeRequired = chargeRequired;
    }

    public int getCharge() {
        return chargeRequired;
    }

    public abstract void doSkill();

    public abstract void handleTelegraphAttack(Vector3 position, int stage);
}

