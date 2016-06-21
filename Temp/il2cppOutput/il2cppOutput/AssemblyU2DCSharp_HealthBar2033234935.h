#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Transform
struct Transform_t284553113;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector33525329789.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// HealthBar
struct  HealthBar_t2033234935  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Vector3 HealthBar::offset
	Vector3_t3525329789  ___offset_2;
	// UnityEngine.Transform HealthBar::player
	Transform_t284553113 * ___player_3;

public:
	inline static int32_t get_offset_of_offset_2() { return static_cast<int32_t>(offsetof(HealthBar_t2033234935, ___offset_2)); }
	inline Vector3_t3525329789  get_offset_2() const { return ___offset_2; }
	inline Vector3_t3525329789 * get_address_of_offset_2() { return &___offset_2; }
	inline void set_offset_2(Vector3_t3525329789  value)
	{
		___offset_2 = value;
	}

	inline static int32_t get_offset_of_player_3() { return static_cast<int32_t>(offsetof(HealthBar_t2033234935, ___player_3)); }
	inline Transform_t284553113 * get_player_3() const { return ___player_3; }
	inline Transform_t284553113 ** get_address_of_player_3() { return &___player_3; }
	inline void set_player_3(Transform_t284553113 * value)
	{
		___player_3 = value;
		Il2CppCodeGenWriteBarrier(&___player_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
