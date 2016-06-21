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
// UnityEngine.Transform
struct Transform_t284553113;

#include "AssemblyU2DCSharp_AbstractBehavior320735412.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// ShieldProjectile
struct  ShieldProjectile_t3401947730  : public AbstractBehavior_t320735412
{
public:
	// System.Single ShieldProjectile::shieldDelay
	float ___shieldDelay_6;
	// UnityEngine.GameObject ShieldProjectile::projectilePrefab
	GameObject_t4012695102 * ___projectilePrefab_7;
	// UnityEngine.GameObject ShieldProjectile::target
	GameObject_t4012695102 * ___target_8;
	// UnityEngine.Transform ShieldProjectile::_t
	Transform_t284553113 * ____t_9;
	// System.Single ShieldProjectile::timeElapsed
	float ___timeElapsed_10;

public:
	inline static int32_t get_offset_of_shieldDelay_6() { return static_cast<int32_t>(offsetof(ShieldProjectile_t3401947730, ___shieldDelay_6)); }
	inline float get_shieldDelay_6() const { return ___shieldDelay_6; }
	inline float* get_address_of_shieldDelay_6() { return &___shieldDelay_6; }
	inline void set_shieldDelay_6(float value)
	{
		___shieldDelay_6 = value;
	}

	inline static int32_t get_offset_of_projectilePrefab_7() { return static_cast<int32_t>(offsetof(ShieldProjectile_t3401947730, ___projectilePrefab_7)); }
	inline GameObject_t4012695102 * get_projectilePrefab_7() const { return ___projectilePrefab_7; }
	inline GameObject_t4012695102 ** get_address_of_projectilePrefab_7() { return &___projectilePrefab_7; }
	inline void set_projectilePrefab_7(GameObject_t4012695102 * value)
	{
		___projectilePrefab_7 = value;
		Il2CppCodeGenWriteBarrier(&___projectilePrefab_7, value);
	}

	inline static int32_t get_offset_of_target_8() { return static_cast<int32_t>(offsetof(ShieldProjectile_t3401947730, ___target_8)); }
	inline GameObject_t4012695102 * get_target_8() const { return ___target_8; }
	inline GameObject_t4012695102 ** get_address_of_target_8() { return &___target_8; }
	inline void set_target_8(GameObject_t4012695102 * value)
	{
		___target_8 = value;
		Il2CppCodeGenWriteBarrier(&___target_8, value);
	}

	inline static int32_t get_offset_of__t_9() { return static_cast<int32_t>(offsetof(ShieldProjectile_t3401947730, ____t_9)); }
	inline Transform_t284553113 * get__t_9() const { return ____t_9; }
	inline Transform_t284553113 ** get_address_of__t_9() { return &____t_9; }
	inline void set__t_9(Transform_t284553113 * value)
	{
		____t_9 = value;
		Il2CppCodeGenWriteBarrier(&____t_9, value);
	}

	inline static int32_t get_offset_of_timeElapsed_10() { return static_cast<int32_t>(offsetof(ShieldProjectile_t3401947730, ___timeElapsed_10)); }
	inline float get_timeElapsed_10() const { return ___timeElapsed_10; }
	inline float* get_address_of_timeElapsed_10() { return &___timeElapsed_10; }
	inline void set_timeElapsed_10(float value)
	{
		___timeElapsed_10 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
