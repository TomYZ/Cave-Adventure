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

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BGEdgecontroll
struct  BGEdgecontroll_t1149092945  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.GameObject BGEdgecontroll::target
	GameObject_t4012695102 * ___target_2;
	// UnityEngine.Transform BGEdgecontroll::_t
	Transform_t284553113 * ____t_3;
	// System.Single BGEdgecontroll::threshold
	float ___threshold_4;
	// System.Single BGEdgecontroll::last_position
	float ___last_position_5;

public:
	inline static int32_t get_offset_of_target_2() { return static_cast<int32_t>(offsetof(BGEdgecontroll_t1149092945, ___target_2)); }
	inline GameObject_t4012695102 * get_target_2() const { return ___target_2; }
	inline GameObject_t4012695102 ** get_address_of_target_2() { return &___target_2; }
	inline void set_target_2(GameObject_t4012695102 * value)
	{
		___target_2 = value;
		Il2CppCodeGenWriteBarrier(&___target_2, value);
	}

	inline static int32_t get_offset_of__t_3() { return static_cast<int32_t>(offsetof(BGEdgecontroll_t1149092945, ____t_3)); }
	inline Transform_t284553113 * get__t_3() const { return ____t_3; }
	inline Transform_t284553113 ** get_address_of__t_3() { return &____t_3; }
	inline void set__t_3(Transform_t284553113 * value)
	{
		____t_3 = value;
		Il2CppCodeGenWriteBarrier(&____t_3, value);
	}

	inline static int32_t get_offset_of_threshold_4() { return static_cast<int32_t>(offsetof(BGEdgecontroll_t1149092945, ___threshold_4)); }
	inline float get_threshold_4() const { return ___threshold_4; }
	inline float* get_address_of_threshold_4() { return &___threshold_4; }
	inline void set_threshold_4(float value)
	{
		___threshold_4 = value;
	}

	inline static int32_t get_offset_of_last_position_5() { return static_cast<int32_t>(offsetof(BGEdgecontroll_t1149092945, ___last_position_5)); }
	inline float get_last_position_5() const { return ___last_position_5; }
	inline float* get_address_of_last_position_5() { return &___last_position_5; }
	inline void set_last_position_5(float value)
	{
		___last_position_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
