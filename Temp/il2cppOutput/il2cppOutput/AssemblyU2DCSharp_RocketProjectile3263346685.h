#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;

#include "AssemblyU2DCSharp_AbstractBehavior320735412.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// RocketProjectile
struct  RocketProjectile_t3263346685  : public AbstractBehavior_t320735412
{
public:
	// System.Single RocketProjectile::shootDelay
	float ___shootDelay_6;
	// UnityEngine.GameObject RocketProjectile::projectilePrefab
	GameObject_t4012695102 * ___projectilePrefab_7;
	// System.Single RocketProjectile::timeElapsed
	float ___timeElapsed_8;

public:
	inline static int32_t get_offset_of_shootDelay_6() { return static_cast<int32_t>(offsetof(RocketProjectile_t3263346685, ___shootDelay_6)); }
	inline float get_shootDelay_6() const { return ___shootDelay_6; }
	inline float* get_address_of_shootDelay_6() { return &___shootDelay_6; }
	inline void set_shootDelay_6(float value)
	{
		___shootDelay_6 = value;
	}

	inline static int32_t get_offset_of_projectilePrefab_7() { return static_cast<int32_t>(offsetof(RocketProjectile_t3263346685, ___projectilePrefab_7)); }
	inline GameObject_t4012695102 * get_projectilePrefab_7() const { return ___projectilePrefab_7; }
	inline GameObject_t4012695102 ** get_address_of_projectilePrefab_7() { return &___projectilePrefab_7; }
	inline void set_projectilePrefab_7(GameObject_t4012695102 * value)
	{
		___projectilePrefab_7 = value;
		Il2CppCodeGenWriteBarrier(&___projectilePrefab_7, value);
	}

	inline static int32_t get_offset_of_timeElapsed_8() { return static_cast<int32_t>(offsetof(RocketProjectile_t3263346685, ___timeElapsed_8)); }
	inline float get_timeElapsed_8() const { return ___timeElapsed_8; }
	inline float* get_address_of_timeElapsed_8() { return &___timeElapsed_8; }
	inline void set_timeElapsed_8(float value)
	{
		___timeElapsed_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
