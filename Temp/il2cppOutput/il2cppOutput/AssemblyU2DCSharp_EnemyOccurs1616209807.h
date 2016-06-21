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

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// EnemyOccurs
struct  EnemyOccurs_t1616209807  : public MonoBehaviour_t3012272455
{
public:
	// System.Single EnemyOccurs::last_position
	float ___last_position_2;
	// System.Single EnemyOccurs::enemy_delay
	float ___enemy_delay_3;
	// System.Single EnemyOccurs::randomNum
	float ___randomNum_4;
	// System.Single EnemyOccurs::slot
	float ___slot_5;
	// UnityEngine.GameObject EnemyOccurs::Ghost_up_prefab
	GameObject_t4012695102 * ___Ghost_up_prefab_6;
	// UnityEngine.GameObject EnemyOccurs::Ghost_left_prefab
	GameObject_t4012695102 * ___Ghost_left_prefab_7;
	// UnityEngine.GameObject EnemyOccurs::Cannon_prefab
	GameObject_t4012695102 * ___Cannon_prefab_8;

public:
	inline static int32_t get_offset_of_last_position_2() { return static_cast<int32_t>(offsetof(EnemyOccurs_t1616209807, ___last_position_2)); }
	inline float get_last_position_2() const { return ___last_position_2; }
	inline float* get_address_of_last_position_2() { return &___last_position_2; }
	inline void set_last_position_2(float value)
	{
		___last_position_2 = value;
	}

	inline static int32_t get_offset_of_enemy_delay_3() { return static_cast<int32_t>(offsetof(EnemyOccurs_t1616209807, ___enemy_delay_3)); }
	inline float get_enemy_delay_3() const { return ___enemy_delay_3; }
	inline float* get_address_of_enemy_delay_3() { return &___enemy_delay_3; }
	inline void set_enemy_delay_3(float value)
	{
		___enemy_delay_3 = value;
	}

	inline static int32_t get_offset_of_randomNum_4() { return static_cast<int32_t>(offsetof(EnemyOccurs_t1616209807, ___randomNum_4)); }
	inline float get_randomNum_4() const { return ___randomNum_4; }
	inline float* get_address_of_randomNum_4() { return &___randomNum_4; }
	inline void set_randomNum_4(float value)
	{
		___randomNum_4 = value;
	}

	inline static int32_t get_offset_of_slot_5() { return static_cast<int32_t>(offsetof(EnemyOccurs_t1616209807, ___slot_5)); }
	inline float get_slot_5() const { return ___slot_5; }
	inline float* get_address_of_slot_5() { return &___slot_5; }
	inline void set_slot_5(float value)
	{
		___slot_5 = value;
	}

	inline static int32_t get_offset_of_Ghost_up_prefab_6() { return static_cast<int32_t>(offsetof(EnemyOccurs_t1616209807, ___Ghost_up_prefab_6)); }
	inline GameObject_t4012695102 * get_Ghost_up_prefab_6() const { return ___Ghost_up_prefab_6; }
	inline GameObject_t4012695102 ** get_address_of_Ghost_up_prefab_6() { return &___Ghost_up_prefab_6; }
	inline void set_Ghost_up_prefab_6(GameObject_t4012695102 * value)
	{
		___Ghost_up_prefab_6 = value;
		Il2CppCodeGenWriteBarrier(&___Ghost_up_prefab_6, value);
	}

	inline static int32_t get_offset_of_Ghost_left_prefab_7() { return static_cast<int32_t>(offsetof(EnemyOccurs_t1616209807, ___Ghost_left_prefab_7)); }
	inline GameObject_t4012695102 * get_Ghost_left_prefab_7() const { return ___Ghost_left_prefab_7; }
	inline GameObject_t4012695102 ** get_address_of_Ghost_left_prefab_7() { return &___Ghost_left_prefab_7; }
	inline void set_Ghost_left_prefab_7(GameObject_t4012695102 * value)
	{
		___Ghost_left_prefab_7 = value;
		Il2CppCodeGenWriteBarrier(&___Ghost_left_prefab_7, value);
	}

	inline static int32_t get_offset_of_Cannon_prefab_8() { return static_cast<int32_t>(offsetof(EnemyOccurs_t1616209807, ___Cannon_prefab_8)); }
	inline GameObject_t4012695102 * get_Cannon_prefab_8() const { return ___Cannon_prefab_8; }
	inline GameObject_t4012695102 ** get_address_of_Cannon_prefab_8() { return &___Cannon_prefab_8; }
	inline void set_Cannon_prefab_8(GameObject_t4012695102 * value)
	{
		___Cannon_prefab_8 = value;
		Il2CppCodeGenWriteBarrier(&___Cannon_prefab_8, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
